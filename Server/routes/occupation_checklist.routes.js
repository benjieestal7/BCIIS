const express = require("express");
const occupation_checklist = express.Router();
//const cors = require("cors");
const db = require("../database/config");
//const csrf = require('csurf');
//const config = require('../database/config.json');

//const security = require('../database/security');

occupation_checklist.post('/add', (req, res) => {
    db.sequelize.query("CALL sp_occupation_checklist_add(:profile_id, :occupation_id)", {
        replacements: {
            profile_id: req.body.profile_id,
            occupation_id: req.body.occupation_id,
        }
    }).then(data => {
        ret = data[0]["_ret"];
        if (ret === "add_successfully") {
            res.send({error: false, message: 'add_successfully'});
        } 
        else if (ret === "edit_successfully") {
            res.send({error: false, message: 'occupation_checklist_updated_successfully'});
        } else if (ret === "invalid_occupation_checklist_duplicate") {
            res.send({error: false, message: 'invalid_occupation_checklist_duplicate'});
        }
        else {
            res.send({error: false, message: 'Unknown Error.'});
        }
    }).catch(err => {
        res.send({ error: true, message: `Error 767: ${err}` });
    });
});



occupation_checklist.post('/get_all', (req, res) => {
    db.sequelize.query("CALL sp_profile_occupation_get(:profile_id)", {
        type: db.sequelize.QueryTypes.SELECT,
        replacements: {
            profile_id: req.body.profile_id,
        }
    }).then((data) => {
        const data_ret = db.MultiQueryResult(data).result0;
        if (data_ret) {
            res.send(data_ret);
        } else {
            res.send(`no_data`);
        }
    }).catch(err => {
        res.send(`Error: ${err}`);
    });
});


module.exports = occupation_checklist;