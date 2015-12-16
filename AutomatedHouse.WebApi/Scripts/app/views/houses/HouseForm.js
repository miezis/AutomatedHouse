import _ from 'lodash';
import react from 'react';
import DocumentTitle from 'react-document-title';

class HouseForm extends react.Component {
  constructor(props) {
    super(props);
  }
 
  render() {
    const props = this.props;

    return (
      <form onSubmit={this.submitForm.bind(this)}>
        <div className="form-group">
          <input type="text" ref={(ref) => this.nameInput = ref} defaultValue={props.name} />
        </div>
        <div className="form-group">
          <input type="text" ref={(ref) => this.apiKeyInput = ref} defaultValue={props.apiKey} />
        </div>
        <button className="btn btn-default" type="submit">Create</button>
      </form>
    );
  }

  submitForm(e) {
    e.preventDefault();

    this.props.onSubmit({
      name: this.nameInput.value,
      apiKey: this.apiKeyInput.value
    });
  }
}

export default HouseForm;