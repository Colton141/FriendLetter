using FriendLetter.Models;

namespace FriendLetter.Models
{
  public class LetterVariable
  {
    private string _recipient;
    private string _sender;
    private string _location;
    private string _souvenir;

    public string Recipient { get => _recipient ; set => _recipient = value;  }

    public string Sender { get => _sender; set => _sender = value; }

    public string Location { get => _location; set => _location = value; }

    public string Souvenir { get => _souvenir; set => _souvenir = value; }

  }
}
