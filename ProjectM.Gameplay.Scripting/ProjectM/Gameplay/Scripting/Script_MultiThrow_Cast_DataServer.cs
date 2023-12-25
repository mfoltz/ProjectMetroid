// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_MultiThrow_Cast_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_MultiThrow_Cast_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_OffsetAngle;
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomAngle;
    private static readonly System.IntPtr NativeFieldInfoPtr_NewThrowEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_IndividualRandom;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseAimDirection;
    [FieldOffset(0)]
    public float MinRange;
    [FieldOffset(4)]
    public float MaxRange;
    [FieldOffset(8)]
    public float OffsetAngle;
    [FieldOffset(12)]
    public float RandomAngle;
    [FieldOffset(16)]
    public PrefabGUID NewThrowEntity;
    [FieldOffset(20)]
    public int Count;
    [FieldOffset(24)]
    public bool IndividualRandom;
    [FieldOffset(25)]
    public bool UseAimDirection;

    static Script_MultiThrow_Cast_DataServer()
    {
      Il2CppClassPointerStore<Script_MultiThrow_Cast_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_MultiThrow_Cast_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_MultiThrow_Cast_DataServer>.NativeClassPtr);
      Script_MultiThrow_Cast_DataServer.NativeFieldInfoPtr_MinRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_MultiThrow_Cast_DataServer>.NativeClassPtr, nameof (MinRange));
      Script_MultiThrow_Cast_DataServer.NativeFieldInfoPtr_MaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_MultiThrow_Cast_DataServer>.NativeClassPtr, nameof (MaxRange));
      Script_MultiThrow_Cast_DataServer.NativeFieldInfoPtr_OffsetAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_MultiThrow_Cast_DataServer>.NativeClassPtr, nameof (OffsetAngle));
      Script_MultiThrow_Cast_DataServer.NativeFieldInfoPtr_RandomAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_MultiThrow_Cast_DataServer>.NativeClassPtr, nameof (RandomAngle));
      Script_MultiThrow_Cast_DataServer.NativeFieldInfoPtr_NewThrowEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_MultiThrow_Cast_DataServer>.NativeClassPtr, nameof (NewThrowEntity));
      Script_MultiThrow_Cast_DataServer.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_MultiThrow_Cast_DataServer>.NativeClassPtr, nameof (Count));
      Script_MultiThrow_Cast_DataServer.NativeFieldInfoPtr_IndividualRandom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_MultiThrow_Cast_DataServer>.NativeClassPtr, nameof (IndividualRandom));
      Script_MultiThrow_Cast_DataServer.NativeFieldInfoPtr_UseAimDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_MultiThrow_Cast_DataServer>.NativeClassPtr, nameof (UseAimDirection));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_MultiThrow_Cast_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
