import _ from 'lodash';
import react from 'react';
import Modal from 'react-modal';
import DocumentTitle from 'react-document-title';
import connectToStores from 'alt/utils/connectToStores';

import RoomsActions from './RoomsActions';
import RoomsStore from './RoomsStore';

import RoomForm from './RoomForm';
import Accessories from './accessories/Accessories';
import Sensors from './sensors/Sensors';

@connectToStores
class Rooms extends react.Component {
  constructor(props) {
    super(props);

    this.state = {
      createModalOpen: false
    };

    RoomsActions.getRooms(props.params.id);
  }
 
  render() {
    const props = this.props;
    const state = this.state;

    const customStyle = {content: {top: '50%', bottom: 'auto'}};

    return (
      <div>
        <DocumentTitle title="Rooms"/>
        <button className="btn btn-default" onClick={this.openCreateModal.bind(this)}>Create Room</button>
        <div className="row">{this.renderRooms(props.rooms)}</div>
        <Modal style={customStyle} isOpen={state.createModalOpen} onRequestClose={this.closeCreateModal.bind(this)}>
            <RoomForm onSubmit={this.createRoom.bind(this)} />
        </Modal>
      </div>
    );
  }

  renderRooms(rooms) {
    if (rooms && !rooms.length || !rooms) {
      return <p>There are no rooms yet.</p>;
    }

    return _.map(rooms, (room) => (
        <div className="col-xs-12" key={room.Id}>
          <div className="panel panel-default">
            <div className="panel-heading">
              <h3 className="panel-title">{room.Name}</h3>
            </div>
            <div className="panel-body">
              <Accessories accessories={room.accessories} updateAccessory={this.updateAccessory.bind(this)} />
              <Sensors sensors={room.sensors} />
            </div>
          </div>
        </div>
    ));
  }

  openCreateModal(e) {
    e.preventDefault();
    this.setState({createModalOpen: true});
  }

  closeCreateModal() {
    this.setState({createModalOpen: false});
  }

  createRoom(name) {
    const houseId = this.props.params.id;

    const payload = {
      name,
      houseId
    };

    this.closeCreateModal();
    RoomsActions.createRoom(payload);
  }

  updateAccessory(accesorry) {
    RoomsActions.updateAccessory(accesorry);
  }

  static getStores(props) {
    return [RoomsStore];
  }

  static getPropsFromStores(props) {
    return RoomsStore.getState();
  }
}

export default Rooms;