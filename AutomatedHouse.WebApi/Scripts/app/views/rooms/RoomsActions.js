import app from '../../App';
import http from '../../utils/http';
 
class RoomsActions {
	getRooms(houseId) {
		http.get(`/rooms/${houseId}`)
			.then((response) => {
				if (response.statusCode === 200) {
					this.dispatch(response.body);
				}
			});
	}
}
 
export default app.createActions(RoomsActions);