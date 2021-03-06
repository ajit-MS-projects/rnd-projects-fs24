﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMqClient
{
	public class Notification
	{
		public virtual ObjectTypes TriggeredOnType { get; set; }
		public virtual NotificationEventTypes NotificationEventType { get; set; }

		/// <summary>
		/// userid is the user who triggers the event.
		/// </summary>
		public virtual int TriggeredById { get; set; }

		/// <summary>
		/// can be partner or user
		/// </summary>
		/// <value>
		/// The type of the triggered by.
		/// </value>
		public string TriggeredByType { get; set; }
		public string TriggeredByWebUrl { get; set; }

		/// <summary>
		/// place hoder for future use in case of mobile push notifications
		/// </summary>
		/// <value>
		/// The triggered by app URL.
		/// </value>
		public string TriggeredByAppUrl { get; set; }

		public virtual int TriggeredOnId { get; set; }
		public string TriggeredOnWebUrl { get; set; }
		public string TiggeredOnAppUrl { get; set; }
		/// <summary>
		/// Ids of notices corresponding to spontacts users or external email ids, who should get notifications.
		/// </summary>
		/// <value>
		/// The notice user ids.
		/// </value>
		public List<int> NoticeIds { get; set; }

	}
	public enum ObjectTypes
	{
		Activity = 1,
		Comment = 2,
		Notice = 3,
		Message = 4,
		User = 5,
	}

	public enum NotificationEventTypes
	{
		None = 0,
		//CreateActivity = 1,//Freinds, interested users if public activity only then
		//UpdateActivity = 2,//obeservers, participants
		//DeleteActivity = 3,//delete all pendng notifications if any, obeservers, participants
		//CommentActivity = 4,//owner, participants excluding the commenting user
		//ParticipateActivity = 5,//owner, and all friends of user who participates
		//RecomendActivity = 6,//target spontacts users or mail to users not with spontatcs
		//InviteActivity = 7,//target spontacts users or mail to users not with spontatcs

		ActivityCreatedByFriend = 1,
		ActivityUpdated = 2,
		ActivityCanceled = 3,
		UserJoinedYourActivity = 4,
		FriendJoinedActivity = 5,
		UserCreated = 6,
		UserConfirmedEmail = 7,
		MessageReceived = 8,
		FriendshipRequested = 9,
		FriendshipAccepted = 10,
		RecommendationReceived = 11,
		InvitationReceived = 12,
		ActivityCommentedByInitiator = 13,
		ActivityCommentedByUser = 14,

		//placeholders
		FacebookFriendRegistered = 15,
		FacebookDeauthorizedValidPassword = 16,
		FacebookDeauthorizedNewPassword = 17,

		RelevantActivityCreated = 18,

		RecommendationReceivedPartner = 19,
		RecommendationReceivedPartnerEvent = 20, //Note: partner event recommendation though an activity is handled seperatly because email template for partner event is different
		RecommendationReceivedPartnerVenue = 21,
		//this is an event genric for a new activity not in ruby but needed as ruby does not know if acivity is relevant or by friend, 1 and 18 will be used to save display_notification row 
		ActivityCreated = 50,
		PartnerEventCreated = 51//this event is generated by a scheduled job every day once at 8:30 am
	}
}
