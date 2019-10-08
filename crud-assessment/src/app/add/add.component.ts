import { Component, OnInit } from '@angular/core';
import { department } from "./../dept";
import { DeptService } from "./../dept.service";

@Component({
  selector: 'app-add',
  templateUrl: './add.component.html',
  styleUrls: ['./add.component.scss']
})
export class AddComponent implements OnInit {

  d=new department()
  constructor(private ds:DeptService) { }

  ngOnInit() {
  }
  saveForm(){
    this.d.date=new Date()
    this.ds.save(this.d)
  }

}
