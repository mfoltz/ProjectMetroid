// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.TimePassedSinceBlackboard
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
  public struct TimePassedSinceBlackboard
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeInSecondsRegister;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeStampRegister;
    private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_Final_New_Boolean_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    [FieldOffset(0)]
    public SharedField<double> TimeInSecondsRegister;
    [FieldOffset(4)]
    public SharedField<double> TimeStampRegister;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1345803, XrefRangeEnd = 1345808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Evaluate(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TimePassedSinceBlackboard.NativeMethodInfoPtr_Evaluate_Public_Virtual_Final_New_Boolean_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TimePassedSinceBlackboard()
    {
      Il2CppClassPointerStore<TimePassedSinceBlackboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (TimePassedSinceBlackboard));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimePassedSinceBlackboard>.NativeClassPtr);
      TimePassedSinceBlackboard.NativeFieldInfoPtr_TimeInSecondsRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimePassedSinceBlackboard>.NativeClassPtr, nameof (TimeInSecondsRegister));
      TimePassedSinceBlackboard.NativeFieldInfoPtr_TimeStampRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimePassedSinceBlackboard>.NativeClassPtr, nameof (TimeStampRegister));
      TimePassedSinceBlackboard.NativeMethodInfoPtr_Evaluate_Public_Virtual_Final_New_Boolean_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimePassedSinceBlackboard>.NativeClassPtr, 100665564);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimePassedSinceBlackboard>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
