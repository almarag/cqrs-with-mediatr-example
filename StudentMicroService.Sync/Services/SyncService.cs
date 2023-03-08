using StudentsMicroService.Infrastructure.Interfaces;

namespace StudentMicroService.Sync.Services
{
    public class SyncService
    {
        private IStudentRepository _studentRepository;
        private IStudentStateRepository _studentStateRepository;
        public SyncService(
            IStudentRepository studentRepository,
            IStudentStateRepository studentStateRepository)
        {
            _studentRepository = studentRepository;
            _studentStateRepository = studentStateRepository; 
        }

        public async Task Sync()
        {
            var states = await _studentStateRepository.GetAllStates();

            foreach (var newStudent in states)
            {
                await _studentRepository.AddStudent(newStudent);
            }

            await _studentStateRepository.Purge();
        }
    }
}
