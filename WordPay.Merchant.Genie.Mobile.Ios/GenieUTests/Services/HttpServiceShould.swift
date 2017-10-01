//
//  HttpServiceShould.swift
//  GenieUTests
//
//  Created by Tai Fa Tang on 26/09/2017.
//  Copyright © 2017 The Pocket Company. All rights reserved.
//

import XCTest
@testable import GenieU

internal class HttpServiceShould : XCTestCase {
    
    var httpSerivce: HttpService!
    
    override func setUp() {
        super.setUp()
        httpSerivce = HttpService()
    }
    
    override func tearDown() {
        super.tearDown()
        httpSerivce = nil
    }
    
     func testMakeHttpGetRequest() {
        let request = URLRequest(url: URL(string: "https://google.com")!)
        
        httpSerivce.get(with: request) { (b, e) in
            print(b)
            
        }
        assert(false)
    }
    
}
