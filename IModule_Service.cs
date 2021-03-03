using Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ALPSService
{
    [ServiceContract]
    public interface IModule_Service
    {
        [OperationContract]
        List<ModuleDTO> findAllModule();
        [OperationContract]
        ModuleDTO findModuleById(string ModuleID);
        [OperationContract]
        void createModule(ModuleDTO newModule);
        [OperationContract]
        void updateModule(ModuleDTO updateModule);
        [OperationContract]
        void deleteModule(string ModuleID);
    }
}
