// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.Relocate_Stuck_FindPos
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Relocate_Stuck_FindPos
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetEntityRegister;
    private static readonly System.IntPtr NativeFieldInfoPtr_OutRegister;
    private static readonly System.IntPtr NativeFieldInfoPtr_MIN_DISTANCE;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    [FieldOffset(0)]
    public SharedField<Entity> TargetEntityRegister;
    [FieldOffset(4)]
    public SharedField<float3> OutRegister;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1345575, XrefRangeEnd = 1345612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe BehaviourTreeResult Initialize(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Relocate_Stuck_FindPos.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BehaviourTreeResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    static Relocate_Stuck_FindPos()
    {
      Il2CppClassPointerStore<Relocate_Stuck_FindPos>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (Relocate_Stuck_FindPos));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Relocate_Stuck_FindPos>.NativeClassPtr);
      Relocate_Stuck_FindPos.NativeFieldInfoPtr_TargetEntityRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Relocate_Stuck_FindPos>.NativeClassPtr, nameof (TargetEntityRegister));
      Relocate_Stuck_FindPos.NativeFieldInfoPtr_OutRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Relocate_Stuck_FindPos>.NativeClassPtr, nameof (OutRegister));
      Relocate_Stuck_FindPos.NativeFieldInfoPtr_MIN_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Relocate_Stuck_FindPos>.NativeClassPtr, nameof (MIN_DISTANCE));
      Relocate_Stuck_FindPos.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Relocate_Stuck_FindPos>.NativeClassPtr, 100665546);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Relocate_Stuck_FindPos>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe float MIN_DISTANCE
    {
      get
      {
        float minDistance;
        IL2CPP.il2cpp_field_static_get_value(Relocate_Stuck_FindPos.NativeFieldInfoPtr_MIN_DISTANCE, (void*) &minDistance);
        return minDistance;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Relocate_Stuck_FindPos.NativeFieldInfoPtr_MIN_DISTANCE, (void*) &value);
      }
    }
  }
}
