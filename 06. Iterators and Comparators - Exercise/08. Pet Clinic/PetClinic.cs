namespace _08._Pet_Clinic
{
    using System;
    using System.Linq;
    using System.Text;

    public class PetClinic
    {
        private readonly Pet[] pets;

        public PetClinic(string name, int roomsCount)
        {
            this.CheckRoomsCount(roomsCount);
            this.pets = new Pet[roomsCount];
            this.Name = name;
        }

        public string Name { get; set; }

        public int Center => this.pets.Length / 2;

        public bool HasEmptyRooms => this.pets.Any(p => p == null);

        public bool AddPet(Pet pet)
        {
            var currentRoomIndex = this.Center;

            for (int i = 0; i < this.pets.Length; i++)
            {
                if (i % 2 == 0)
                {
                    currentRoomIndex += i;
                }
                else
                {
                    currentRoomIndex -= i;
                }

                if (this.pets[currentRoomIndex] == null)
                {
                    this.pets[currentRoomIndex] = pet;
                    return true;
                }
            }

            return false;
        }

        public bool Release()
        {
            for (int i = 0; i < this.pets.Length; i++)
            {
                var index = (this.Center + i) % this.pets.Length;

                if (this.pets[index] != null)
                {
                    this.pets[index] = null;
                    return true;
                }
            }

            return false;
        }

        public string GetRoomState(int roomNumber)
        {
            return this.pets[roomNumber - 1]?.ToString() ?? "Room empty";
        }

        public string GetAllRoomsState()
        {
            var stringBuilder = new StringBuilder();

            for (int i = 1; i <= this.pets.Length; i++)
            {
                stringBuilder.AppendLine(this.GetRoomState(i));
            }

            return stringBuilder.ToString().Trim();
        }

        private void CheckRoomsCount(int roomsCount)
        {
            if (roomsCount % 2 == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
        }
    }
}