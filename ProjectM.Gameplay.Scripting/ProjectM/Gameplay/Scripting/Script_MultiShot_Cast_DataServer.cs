// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_MultiShot_Cast_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_MultiShot_Cast_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Angle;
    private static readonly System.IntPtr NativeFieldInfoPtr_OffsetAllAngles;
    private static readonly System.IntPtr NativeFieldInfoPtr_NewProjectile;
    private static readonly System.IntPtr NativeFieldInfoPtr_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_Condition;
    [FieldOffset(0)]
    public float Angle;
    [FieldOffset(4)]
    public float OffsetAllAngles;
    [FieldOffset(8)]
    public PrefabGUID NewProjectile;
    [FieldOffset(12)]
    public int Count;
    [FieldOffset(16)]
    public BlobAssetReference<ConditionBlob> Condition;

    static Script_MultiShot_Cast_DataServer()
    {
      Il2CppClassPointerStore<Script_MultiShot_Cast_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_MultiShot_Cast_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_MultiShot_Cast_DataServer>.NativeClassPtr);
      Script_MultiShot_Cast_DataServer.NativeFieldInfoPtr_Angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_MultiShot_Cast_DataServer>.NativeClassPtr, nameof (Angle));
      Script_MultiShot_Cast_DataServer.NativeFieldInfoPtr_OffsetAllAngles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_MultiShot_Cast_DataServer>.NativeClassPtr, nameof (OffsetAllAngles));
      Script_MultiShot_Cast_DataServer.NativeFieldInfoPtr_NewProjectile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_MultiShot_Cast_DataServer>.NativeClassPtr, nameof (NewProjectile));
      Script_MultiShot_Cast_DataServer.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_MultiShot_Cast_DataServer>.NativeClassPtr, nameof (Count));
      Script_MultiShot_Cast_DataServer.NativeFieldInfoPtr_Condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_MultiShot_Cast_DataServer>.NativeClassPtr, nameof (Condition));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_MultiShot_Cast_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
