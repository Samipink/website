﻿using System;

public class DisplayPersonModel
{
	public DisplayPersonModel()
	{
		[Required]
		[StringLength(15, ErrorMessage = "First Name is too long")]
		[MinLength(3, ErrorMessage = "First Name is too short")]
		public string FirstName { get; set; }
		
		[Required]
		[StringLength(15, ErrorMessage = "Last Name is too long")]
		[MinLength(3, ErrorMessage = "Last Name is too short")]
        public string LastName { get; set; }
		
		[Required]
		[EmailAddress]
        public string EmailAddress { get; set; }
	}
}
