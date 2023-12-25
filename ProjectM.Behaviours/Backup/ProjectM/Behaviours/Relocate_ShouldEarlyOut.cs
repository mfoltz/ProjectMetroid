// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.Relocate_ShouldEarlyOut
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Relocate_ShouldEarlyOut
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxAngle;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetEntityRegister;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartTimeRegister;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Tick_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    [FieldOffset(0)]
    public float MaxAngle;
    [FieldOffset(4)]
    public float MinTime;
    [FieldOffset(8)]
    public SharedField<Entity> TargetEntityRegister;
    [FieldOffset(12)]
    public PrivateField<double> StartTimeRegister;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1345547, XrefRangeEnd = 1345550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe BehaviourTreeResult Initialize(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Relocate_ShouldEarlyOut.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BehaviourTreeResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1345550, XrefRangeEnd = 1345575, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe BehaviourTreeResult Tick(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Relocate_ShouldEarlyOut.NativeMethodInfoPtr_Tick_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BehaviourTreeResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    static Relocate_ShouldEarlyOut()
    {
      Il2CppClassPointerStore<Relocate_ShouldEarlyOut>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (Relocate_ShouldEarlyOut));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Relocate_ShouldEarlyOut>.NativeClassPtr);
      Relocate_ShouldEarlyOut.NativeFieldInfoPtr_MaxAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Relocate_ShouldEarlyOut>.NativeClassPtr, nameof (MaxAngle));
      Relocate_ShouldEarlyOut.NativeFieldInfoPtr_MinTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Relocate_ShouldEarlyOut>.NativeClassPtr, nameof (MinTime));
      Relocate_ShouldEarlyOut.NativeFieldInfoPtr_TargetEntityRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Relocate_ShouldEarlyOut>.NativeClassPtr, nameof (TargetEntityRegister));
      Relocate_ShouldEarlyOut.NativeFieldInfoPtr_StartTimeRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Relocate_ShouldEarlyOut>.NativeClassPtr, nameof (StartTimeRegister));
      Relocate_ShouldEarlyOut.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Relocate_ShouldEarlyOut>.NativeClassPtr, 100665544);
      Relocate_ShouldEarlyOut.NativeMethodInfoPtr_Tick_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Relocate_ShouldEarlyOut>.NativeClassPtr, 100665545);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Relocate_ShouldEarlyOut>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
