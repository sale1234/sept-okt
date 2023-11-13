using Domen;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class ClientHandler
    {
        private Socket clientSocket;
        private CommunicationHelper helper;

        public ClientHandler(Socket clientSocket)
        {
            this.clientSocket = clientSocket;
            helper = new CommunicationHelper(clientSocket);
        }

        public void handleClientRequest()
        {
            try
            {
                while (true)
                {
                    Request request = helper.GetResponse<Request>();

                    switch (request.Operation)
                    {
                        case Operation.Login:
                            Login((RadnikSluzbe)request.RequestObj);
                            break;
                        case Operation.DodajPredmet:
                            DodajPredmet((Predmet)request.RequestObj);
                            break;
                        case Operation.VratiPredmete:
                            VratiPredmete();
                            break;
                        case Operation.VratiMojePredmete:
                            VratiMojePredmete((RadnikSluzbe)request.RequestObj);
                            break;
                        case Operation.SacuvajProfesora:
                            SacuvajProfesora((Profesor)request.RequestObj);
                            break;
                        case Operation.VratiAngazovanja:
                            VratiAngazovanja((Predmet)request.RequestObj);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (IOException ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void VratiMojePredmete(RadnikSluzbe radnik)
        {
            List<Predmet> predmeti = Controller.Instance.VratiMojePredmete(radnik);

            helper.SendRequest(new Response
            {
                ResponseObj = predmeti,
                isSuccessfull = predmeti != null ? true : false
            });
        }

        private void VratiAngazovanja(Predmet predmet)
        {
            List<Angazovanje> angazovanja = Controller.Instance.VratiAngazovanja(predmet);

            helper.SendRequest(new Response
            {
                ResponseObj = angazovanja,
                isSuccessfull = angazovanja != null ? true : false
            });
        }

        private void SacuvajProfesora(Profesor profesor)
        {
            Controller.Instance.SacuvajProfesora(profesor);
        }

        private void VratiPredmete()
        {
            List<Predmet> predmeti = Controller.Instance.VratiPredmete();

            if (predmeti != null)
            {
                helper.SendRequest(new Response
                {
                    isSuccessfull = true,
                    ResponseObj = predmeti
                });
            }
            else
            {
                helper.SendRequest(new Response
                {
                    isSuccessfull = false,
                    Message = "Greska pri vracanju predmeta"
                });
            }
        }

        private void DodajPredmet(Predmet predmet)
        {
            bool isPredmetAdded = Controller.Instance.DodajPredmet(predmet);

            if (isPredmetAdded)
            {
                helper.SendRequest(new Response
                {
                    isSuccessfull = true,
                    Message = "Predmet je uspesno dodat",
                });
            }
            else
            {
                helper.SendRequest(new Response
                {
                    isSuccessfull = false,
                    Message = "Greska pri dodavanju predmeta",
                });
            }
        }

        private void Login(RadnikSluzbe requestObj)
        {
            List<RadnikSluzbe> radnici = Controller.Instance.VratiSveRadnike();
            Response response;

            RadnikSluzbe radnik = radnici.FirstOrDefault(r => r.Email == requestObj.Email && r.Password == requestObj.Password);

            if (radnik != null)
            {
                if (Controller.Instance.UlogovaniRadnici.Contains(radnik))
                {
                    response = new Response
                    {
                        isSuccessfull = false,
                        Message = "Radnik je vec ulogovan"
                    };

                    helper.SendRequest(response);

                }
                else
                {
                    if (Controller.Instance.UlogovaniRadnici.Count == 3)
                    {
                        response = new Response
                        {
                            isSuccessfull = false,
                            Message = "Vec je ulogovano 3 radnika"
                        };
                        helper.SendRequest(response);

                    }
                    else
                    {
                        Controller.Instance.UlogovaniRadnici.Add(radnik);
                        response = new Response
                        {
                            isSuccessfull = true,
                            ResponseObj = radnik
                        };
                        helper.SendRequest(response);
                    }

                }
            }
            else
            {
                response = new Response
                {
                    isSuccessfull = false,
                    Message = "Radnik se ne nalazi u bazi"
                };

                helper.SendRequest(response);
            }

        }
    }
}
