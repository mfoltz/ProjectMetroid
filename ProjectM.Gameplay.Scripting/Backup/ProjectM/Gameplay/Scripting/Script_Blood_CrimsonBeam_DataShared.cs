// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Blood_CrimsonBeam_DataShared
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_Blood_CrimsonBeam_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_HitFilterInt;
    private static readonly System.IntPtr NativeFieldInfoPtr_BoxSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_BoxOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetFilterCondition;
    [FieldOffset(0)]
    public byte HitFilterInt;
    [FieldOffset(4)]
    public float3 BoxSize;
    [FieldOffset(16)]
    public float3 BoxOffset;
    [FieldOffset(32)]
    public BlobAssetReference<ConditionBlob> TargetFilterCondition;

    static Script_Blood_CrimsonBeam_DataShared()
    {
      Il2CppClassPointerStore<Script_Blood_CrimsonBeam_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Blood_CrimsonBeam_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Blood_CrimsonBeam_DataShared>.NativeClassPtr);
      Script_Blood_CrimsonBeam_DataShared.NativeFieldInfoPtr_HitFilterInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Blood_CrimsonBeam_DataShared>.NativeClassPtr, nameof (HitFilterInt));
      Script_Blood_CrimsonBeam_DataShared.NativeFieldInfoPtr_BoxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Blood_CrimsonBeam_DataShared>.NativeClassPtr, nameof (BoxSize));
      Script_Blood_CrimsonBeam_DataShared.NativeFieldInfoPtr_BoxOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Blood_CrimsonBeam_DataShared>.NativeClassPtr, nameof (BoxOffset));
      Script_Blood_CrimsonBeam_DataShared.NativeFieldInfoPtr_TargetFilterCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Blood_CrimsonBeam_DataShared>.NativeClassPtr, nameof (TargetFilterCondition));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_Blood_CrimsonBeam_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
