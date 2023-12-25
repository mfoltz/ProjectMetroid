// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_LightningProjectile_DataShared
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_LightningProjectile_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinAnglePerNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxAnglePerNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_Range;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinRangeForAngleChange;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxRangeForAngleChange;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartRight;
    private static readonly System.IntPtr NativeFieldInfoPtr_InitialRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_InitialPosition;
    [FieldOffset(0)]
    public float MinAnglePerNode;
    [FieldOffset(4)]
    public float MaxAnglePerNode;
    [FieldOffset(8)]
    public float Range;
    [FieldOffset(12)]
    public float MinRangeForAngleChange;
    [FieldOffset(16)]
    public float MaxRangeForAngleChange;
    [FieldOffset(20)]
    public bool StartRight;
    [FieldOffset(24)]
    public quaternion InitialRotation;
    [FieldOffset(40)]
    public float3 InitialPosition;

    static Script_LightningProjectile_DataShared()
    {
      Il2CppClassPointerStore<Script_LightningProjectile_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_LightningProjectile_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_LightningProjectile_DataShared>.NativeClassPtr);
      Script_LightningProjectile_DataShared.NativeFieldInfoPtr_MinAnglePerNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_LightningProjectile_DataShared>.NativeClassPtr, nameof (MinAnglePerNode));
      Script_LightningProjectile_DataShared.NativeFieldInfoPtr_MaxAnglePerNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_LightningProjectile_DataShared>.NativeClassPtr, nameof (MaxAnglePerNode));
      Script_LightningProjectile_DataShared.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_LightningProjectile_DataShared>.NativeClassPtr, nameof (Range));
      Script_LightningProjectile_DataShared.NativeFieldInfoPtr_MinRangeForAngleChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_LightningProjectile_DataShared>.NativeClassPtr, nameof (MinRangeForAngleChange));
      Script_LightningProjectile_DataShared.NativeFieldInfoPtr_MaxRangeForAngleChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_LightningProjectile_DataShared>.NativeClassPtr, nameof (MaxRangeForAngleChange));
      Script_LightningProjectile_DataShared.NativeFieldInfoPtr_StartRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_LightningProjectile_DataShared>.NativeClassPtr, nameof (StartRight));
      Script_LightningProjectile_DataShared.NativeFieldInfoPtr_InitialRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_LightningProjectile_DataShared>.NativeClassPtr, nameof (InitialRotation));
      Script_LightningProjectile_DataShared.NativeFieldInfoPtr_InitialPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_LightningProjectile_DataShared>.NativeClassPtr, nameof (InitialPosition));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_LightningProjectile_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
