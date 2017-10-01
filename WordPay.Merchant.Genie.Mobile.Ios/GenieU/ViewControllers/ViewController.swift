//
//  ViewController.swift
//  GenieU
//
//  Created by Tai Fa Tang on 26/09/2017.
//  Copyright © 2017 The Pocket Company. All rights reserved.
//

import UIKit

class ViewController: UIViewController {

    var httpService: HttpService!
    
    override func viewDidLoad() {
        super.viewDidLoad()
        httpService = HttpService()
        // Do any additional setup after loading the view, typically from a nib.
        test()
    }

    override func didReceiveMemoryWarning() {
        super.didReceiveMemoryWarning()
        // Dispose of any resources that can be recreated.
    }

    func test() {
        let request = URLRequest(url: URL(string: "https://jsonplaceholder.typicode.com/todos")!)
        
        httpService.get(with: request) { (b, e) in
//            print(b)
            
        }
    }

}

