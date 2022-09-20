using System.Drawing;

namespace Tanuki_Chi
{
    public interface TanukiModel
    {
        Image InitImage { get; }
        Image Command(string command);
    }
}
