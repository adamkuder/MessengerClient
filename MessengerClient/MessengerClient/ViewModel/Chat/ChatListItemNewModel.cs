﻿namespace MessengerClient
{
    /// <summary>
    /// A view model for each chat list item in overview chat list 
    /// </summary>
    public class ChatListItemNewModel : BaseViewModel
    {
        /// <summary>
        /// The display name of this chat list
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The lasted message for this chat list
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// The initials to show for the profle picture background
        /// </summary>
        public string Initials { get; set; }

        /// <summary>
        /// The RGB values (in hex) for the background color of the profile picture
        /// For example FF00FF for Red and Blue mixed
        /// </summary>
        public string ProfilePictureRGB { get; set; }
    }
}