/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.linkedmall.Model.V20180116;

namespace Aliyun.Acs.linkedmall.Transform.V20180116
{
    public class CreatePayUrlResponseUnmarshaller
    {
        public static CreatePayUrlResponse Unmarshall(UnmarshallerContext context)
        {
			CreatePayUrlResponse createPayUrlResponse = new CreatePayUrlResponse();

			createPayUrlResponse.HttpResponse = context.HttpResponse;
			createPayUrlResponse.Code = context.StringValue("CreatePayUrl.Code");
			createPayUrlResponse.RequestId = context.StringValue("CreatePayUrl.RequestId");
			createPayUrlResponse.Success = context.BooleanValue("CreatePayUrl.Success");
			createPayUrlResponse.Message = context.StringValue("CreatePayUrl.Message");

			CreatePayUrlResponse.CreatePayUrl_Model model = new CreatePayUrlResponse.CreatePayUrl_Model();
			model.RedirectUrl = context.StringValue("CreatePayUrl.Model.RedirectUrl");

			List<string> model_orderIds = new List<string>();
			for (int i = 0; i < context.Length("CreatePayUrl.Model.OrderIds.Length"); i++) {
				model_orderIds.Add(context.StringValue("CreatePayUrl.Model.OrderIds["+ i +"]"));
			}
			model.OrderIds = model_orderIds;

			List<string> model_payTradeIds = new List<string>();
			for (int i = 0; i < context.Length("CreatePayUrl.Model.PayTradeIds.Length"); i++) {
				model_payTradeIds.Add(context.StringValue("CreatePayUrl.Model.PayTradeIds["+ i +"]"));
			}
			model.PayTradeIds = model_payTradeIds;

			List<string> model_lmOrderList = new List<string>();
			for (int i = 0; i < context.Length("CreatePayUrl.Model.LmOrderList.Length"); i++) {
				model_lmOrderList.Add(context.StringValue("CreatePayUrl.Model.LmOrderList["+ i +"]"));
			}
			model.LmOrderList = model_lmOrderList;
			createPayUrlResponse.Model = model;
        
			return createPayUrlResponse;
        }
    }
}
