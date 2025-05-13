namespace poe
{
    using System;
    using System.IO;
    using System.Media;
    public class PlayNow
    {
        //constructor
        public PlayNow()
        {
            // now get file
            string project_location = AppDomain.CurrentDomain.BaseDirectory;

            //check if it is getting the correct path
            Console.WriteLine(project_location);

            //replacing the bin/debug with the sound file
            string updated_path = project_location.Replace("bin\\Debug\\", "");

            //combining the wav name with updated path
            string full_path = Path.Combine(updated_path, "Chatbot.wav");

            //now lets it it to the play method
            Play_wav(full_path);

        }//end of constructor

        //method to play the sound
        private void Play_wav(string full_path)
        {
            try
            {

                //or play the wav sound
                using (SoundPlayer player = new SoundPlayer(full_path))
                { //to play sound until end of this
                    player.PlaySync();
                }
            }
            catch (Exception error)
            {
                //displaying the error message
                Console.WriteLine(error.Message);
            }//end of try and catch
        }//end of wav method

    }//end of class 

}//end of namespace