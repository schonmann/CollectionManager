using CollectionManager.Models;
namespace CollectionManager.DAO
{
    interface PlaceDAO
    {
        void InsertPlace(Place place);
        Place[] GetAllPlaces();
    }
}
