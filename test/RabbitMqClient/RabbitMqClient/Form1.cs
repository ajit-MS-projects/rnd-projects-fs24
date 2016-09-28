using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RabbitMQ.Client;

namespace RabbitMqClient
{
	public partial class frmQueuer : Form
	{
		public frmQueuer()
		{
			InitializeComponent();
		}

		private IModel channel;
		private IModel exchChannel;

		private void btnSend_Click(object sender, EventArgs e)
		{
			channel = GetChannel(txtQueue.Text);
			byte[] messageBody = Encoding.UTF8.GetBytes(txtMessage.Text + DateTime.Now.ToString());
			channel.BasicPublish("", txtQueue.Text, null, messageBody); //todo exchange name?
		}

		private IModel GetChannel(string queueName)
		{
			if (channel == null || !channel.IsOpen)
			{
				ConnectionFactory connectionFactory = new ConnectionFactory();
				//connectionFactory.Port = 5672;//todo may be get port from config
				IConnection connection = connectionFactory.CreateConnection();
				channel = connection.CreateModel();

				connection.AutoClose = true;

				channel.QueueDeclare(queueName, false, false, false, null);
			}
			return channel;
		}

		private IModel GetExchChannel(string exchName)
		{
			if (exchChannel == null || !exchChannel.IsOpen)
			{
				ConnectionFactory connectionFactory = new ConnectionFactory();
				connectionFactory.HostName = "192.168.156.14";
				//connectionFactory.Port = 5672;//todo may be get port from config
				IConnection connection = connectionFactory.CreateConnection();
				exchChannel = connection.CreateModel();

				connection.AutoClose = true;

				exchChannel.ExchangeDeclare(exchName, ExchangeType.Fanout,true);
				//exchChannel.QueueDeclare(queueName, false, false, false, null);
			}

			return exchChannel;
		}

		private void btnExchMessageSend_Click(object sender, EventArgs e)
		{
			exchChannel = GetExchChannel(txtExch.Text);
			byte[] messageBody = Encoding.UTF8.GetBytes(txtExchMessage.Text + DateTime.Now.ToString());
			exchChannel.BasicPublish(txtExch.Text, "", null, messageBody); //todo exchange name?
		}

		private void frmQueuer_FormClosing(object sender, FormClosingEventArgs e)
		{
			if(channel!=null)
				channel.Close();
			if(exchChannel!=null)
				exchChannel.Close();
		}

		private void btnJson_Click(object sender, EventArgs e)
		{
			exchChannel = GetExchChannel(txtExch.Text);
			Notification n = new Notification();
			n.TriggeredOnId = int.Parse(txtObjectId.Text);

			n.TriggeredById = int.Parse(txtUserId.Text);
			n.TriggeredOnWebUrl = "https://www.spontacts.com/clubbing/muenchen/test111?version=web";
			n.TiggeredOnAppUrl = "actity/12221";
			n.TriggeredByType = "user";
			n.TriggeredByWebUrl = "user/23487";
			switch (comboBox1.Text)
			{
				case "ActivityCreated = 1":
					n.TriggeredOnType = ObjectTypes.Activity;
					n.NotificationEventType = NotificationEventTypes.ActivityCreated;
					break;
				case "ActivityUpdated = 2":
					n.TriggeredOnType = ObjectTypes.Activity;
					n.NotificationEventType = NotificationEventTypes.ActivityUpdated;
					break;
				case "ActivityCanceled = 3":
					n.TriggeredOnType = ObjectTypes.Activity;
					n.NotificationEventType = NotificationEventTypes.ActivityCanceled;
					break;
				case "UserJoinedYourActivity = 4":
					n.TriggeredOnType = ObjectTypes.Activity;
					n.NotificationEventType = NotificationEventTypes.UserJoinedYourActivity;
					break;
				case "FriendJoinedActivity = 5":
					n.TriggeredOnType = ObjectTypes.Activity;
					n.NotificationEventType = NotificationEventTypes.FriendJoinedActivity;
					break;
				case "UserCreated = 6":
					n.TriggeredOnType = ObjectTypes.User;
					n.NotificationEventType = NotificationEventTypes.UserCreated;
					break;
				case "UserConfirmedEmail = 7":
					n.TriggeredOnType = ObjectTypes.User;
					n.NotificationEventType = NotificationEventTypes.UserConfirmedEmail;
					break;
				case "MessageReceived = 8":
					n.TriggeredOnType = ObjectTypes.User;
					n.NotificationEventType = NotificationEventTypes.MessageReceived;
					break;
				case "FriendshipRequested = 9":
					n.TriggeredOnType = ObjectTypes.User;
					n.NotificationEventType = NotificationEventTypes.FriendshipRequested;
					break;
				case "FriendshipAccepted = 10":
					n.TriggeredOnType = ObjectTypes.User;
					n.NotificationEventType = NotificationEventTypes.FriendshipAccepted;
					break;
				case "RecommendationReceived = 11":
					n.TriggeredOnType = ObjectTypes.Notice;
					n.NotificationEventType = NotificationEventTypes.RecommendationReceived;
					break;
				case "InvitationReceived = 12":
					n.TriggeredOnType = ObjectTypes.Notice;
					n.NotificationEventType = NotificationEventTypes.InvitationReceived;
					break;
				case "ActivityCommentedByInitiator = 13":
					n.TriggeredOnType = ObjectTypes.Comment;
					n.NotificationEventType = NotificationEventTypes.ActivityCommentedByInitiator;
					break;
				case "ActivityCommentedByUser = 14":
					n.TriggeredOnType = ObjectTypes.Comment;
					n.NotificationEventType = NotificationEventTypes.ActivityCommentedByUser;
					break;
			}

			

			txtExchMessage.Text = Newtonsoft.Json.JsonConvert.SerializeObject(n);

			byte[] messageBody = Encoding.UTF8.GetBytes(txtExchMessage.Text);
			exchChannel.BasicPublish(txtExch.Text, "", null, messageBody); //todo exchange name?
		}

		
	}
}
