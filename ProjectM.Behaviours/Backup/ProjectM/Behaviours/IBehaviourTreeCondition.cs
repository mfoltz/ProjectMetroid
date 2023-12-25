// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.IBehaviourTreeCondition
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace ProjectM.Behaviours
{
  public class IBehaviourTreeCondition : Il2CppObjectBase
  {
    private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Abstract_Virtual_New_Boolean_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;

    [CallerCount(0)]
    public virtual unsafe bool Evaluate(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) ref context;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref jobData;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IBehaviourTreeCondition.NativeMethodInfoPtr_Evaluate_Public_Abstract_Virtual_New_Boolean_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static IBehaviourTreeCondition()
    {
      Il2CppClassPointerStore<IBehaviourTreeCondition>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (IBehaviourTreeCondition));
      IBehaviourTreeCondition.NativeMethodInfoPtr_Evaluate_Public_Abstract_Virtual_New_Boolean_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBehaviourTreeCondition>.NativeClassPtr, 100665393);
    }

    public IBehaviourTreeCondition(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
