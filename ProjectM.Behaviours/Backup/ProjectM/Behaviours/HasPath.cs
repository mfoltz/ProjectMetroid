﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.HasPath
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct HasPath
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_Final_New_Boolean_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344886, XrefRangeEnd = 1344895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Evaluate(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HasPath.NativeMethodInfoPtr_Evaluate_Public_Virtual_Final_New_Boolean_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static HasPath()
    {
      Il2CppClassPointerStore<HasPath>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (HasPath));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasPath>.NativeClassPtr);
      HasPath.NativeMethodInfoPtr_Evaluate_Public_Virtual_Final_New_Boolean_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasPath>.NativeClassPtr, 100665478);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HasPath>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
