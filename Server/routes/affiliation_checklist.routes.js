const express = require("express");
const affiliation_checklist = express.Router();
//const cors = require("cors");
const db = require("../database/config");
//const csrf = require('csurf');
//const config = require('../database/config.json');

//const security = require('../database/security');

affiliation_checklist.post('/save', (req, res) => {
    db.sequelize.query("CALL sp_affiliation_checklist_save(:id, :profile_id_number, :affiliation_id, :is_active, :position,  :years_in_membership)", {
        replacements: {
            id: parseInt(req.body.id),
            profile_id_number: parseInt(req.body.profile_id_number),
            affiliation_id: parseInt(req.body.affiliation_id),
            is_active: req.body.is_active,
            position: req.body.position,
            years_in_membership: req.body.years_in_membership,
        }
    }).then(data => {
        ret = data[0]["_ret"];
        if (ret === "add_successfully") {
            res.send({error: false, message: 'add_successfully'});
        } 
        else if (ret === "edit_successfully") {
            res.send({error: false, message: 'affiliation_checklist_updated_successfully'});
        } else if (ret === "invalid_affiliation_checklist_duplicate") {
            res.send({error: false, message: 'invalid_affiliation_checklist_duplicate'});
        }
        else {
            res.send({error: false, message: 'Unknown Error.'});
        }
    }).catch(err => {
        res.send({ error: true, message: `Error 767: ${err}` });
    });
});


affiliation_checklist.post('/get_all', (req, res) => {
    db.sequelize.query("CALL sp_profile_affiliation_get(:id_number)", {
        type: db.sequelize.QueryTypes.SELECT,
        replacements: {
            id_number: parseInt(req.body.id_number),
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



module.exports = affiliation_checklist;