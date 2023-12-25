// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.Relocate_CombatArea_FindPos
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
  public struct Relocate_CombatArea_FindPos
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CombatAreaDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinAngle;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetEntityRegister;
    private static readonly System.IntPtr NativeFieldInfoPtr_OutRegister;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    [FieldOffset(0)]
    public float CombatAreaDistance;
    [FieldOffset(4)]
    public float MinAngle;
    [FieldOffset(8)]
    public SharedField<Entity> TargetEntityRegister;
    [FieldOffset(12)]
    public SharedField<float3> OutRegister;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1345526, XrefRangeEnd = 1345547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe BehaviourTreeResult Initialize(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Relocate_CombatArea_FindPos.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BehaviourTreeResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    static Relocate_CombatArea_FindPos()
    {
      Il2CppClassPointerStore<Relocate_CombatArea_FindPos>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (Relocate_CombatArea_FindPos));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Relocate_CombatArea_FindPos>.NativeClassPtr);
      Relocate_CombatArea_FindPos.NativeFieldInfoPtr_CombatAreaDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Relocate_CombatArea_FindPos>.NativeClassPtr, nameof (CombatAreaDistance));
      Relocate_CombatArea_FindPos.NativeFieldInfoPtr_MinAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Relocate_CombatArea_FindPos>.NativeClassPtr, nameof (MinAngle));
      Relocate_CombatArea_FindPos.NativeFieldInfoPtr_TargetEntityRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Relocate_CombatArea_FindPos>.NativeClassPtr, nameof (TargetEntityRegister));
      Relocate_CombatArea_FindPos.NativeFieldInfoPtr_OutRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Relocate_CombatArea_FindPos>.NativeClassPtr, nameof (OutRegister));
      Relocate_CombatArea_FindPos.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Relocate_CombatArea_FindPos>.NativeClassPtr, 100665543);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Relocate_CombatArea_FindPos>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
