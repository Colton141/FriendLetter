using FriendLetter.Models;

namespace FriendLetter.Models
{
  public class LetterVariable
  {
    private string _recipient;
    private string _sender;

    public string Recipient { get => _recipient ; set => _recipient = value;  }

    public string Sender { get => _sender; set => _sender = value; }

  }
}
