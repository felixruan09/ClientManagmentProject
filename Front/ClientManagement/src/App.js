import React from 'react';
import Fab from '@material-ui/core/Fab';
import AddIcon from '@material-ui/icons/Add';
import './App.css';
import AppBar from '@material-ui/core/AppBar';
import Toolbar from '@material-ui/core/Toolbar';
import Typography from '@material-ui/core/Typography';
import ContactCard from './components/ContactCard/ContactCard';
import { getAllEndpoint } from './Config';
import CircularProgress from '@material-ui/core/CircularProgress';
import Modal from '@material-ui/core/Modal';
import ContactModal from './components/Modal/Modal';
export default class App extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      modalOpened: false,
      clientCardList: undefined,
      loading: false
    }
  }
  componentDidMount() {
    this.setState({...this.state, loading: true});
    fetch(getAllEndpoint, { 
      method: 'get'
    })
    .then((response) => {
      if (response.status !== 200) {
        this.setState({...this.state, loading: false});
        alert('Não foi possível carregar os clientes, tente novamente mais tarde.')
      }
      else {
        response.json().then((data) => {
          this.setState({...this.state, clientCardList: data, loading: false});
        });
      }
    })
    .catch(() => {
      this.setState({...this.state, loading: false});
      alert('Não foi possível carregar os clientes, tente novamente mais tarde.')
    })
  }

  openModal = () => {
    this.setState({...this.state, modalOpened: true});
  }

  closeModal = () => {
    this.setState({...this.state, modalOpened: false});
  }

  render() {
    const { clientCardList, loading, modalOpened } = this.state;
    return (
      <div className="main-container">
        <AppBar position="fixed">
          <Toolbar>
            <Typography variant="h6" className="title">
              Clientes
            </Typography>
          </Toolbar>
        </AppBar>
  
        <div className="content-container">
          {loading ? (
            <div className="center-align">
              <CircularProgress />
            </div>
          ) : (
            <div>
              {!!clientCardList && clientCardList.map((clientInfo) => (
                <ContactCard key={clientInfo.document} name={clientInfo.name} document={clientInfo.document} email={clientInfo.mail} openModal={this.openModal}/>
              ))}
            </div>
          )}
        </div>
        
        <Modal
          className="modal"
          open={modalOpened}
          onClose={this.closeModal}
        >
          <ContactModal closeModal={this.closeModal}/>
        </Modal>

        <Fab className="floating-button" color="primary" aria-label="add" onClick={() => this.openModal()}>
          <AddIcon />
        </Fab>
      </div>
    );
  }
}
