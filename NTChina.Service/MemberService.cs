using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NTChina.Domain.Repositories;

namespace NTChina.Service
{
    public class MemberService
    {
         private readonly IMemberRepository _memberRepository;

        public MemberService(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }
    }
}
