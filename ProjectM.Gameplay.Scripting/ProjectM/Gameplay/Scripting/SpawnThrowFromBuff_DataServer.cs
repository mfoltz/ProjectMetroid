// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.SpawnThrowFromBuff_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SpawnThrowFromBuff_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_OffsetAngle;
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomAngle;
    private static readonly System.IntPtr NativeFieldInfoPtr_NewThrowEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_IndividualRandom;
    private static readonly System.IntPtr NativeFieldInfoPtr_AlwaysMaxRange;
    [FieldOffset(0)]
    public float OffsetAngle;
    [FieldOffset(4)]
    public float RandomAngle;
    [FieldOffset(8)]
    public PrefabGUID NewThrowEntity;
    [FieldOffset(12)]
    public int Count;
    [FieldOffset(16)]
    public bool IndividualRandom;
    [FieldOffset(17)]
    public bool AlwaysMaxRange;

    static SpawnThrowFromBuff_DataServer()
    {
      Il2CppClassPointerStore<SpawnThrowFromBuff_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (SpawnThrowFromBuff_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnThrowFromBuff_DataServer>.NativeClassPtr);
      SpawnThrowFromBuff_DataServer.NativeFieldInfoPtr_OffsetAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnThrowFromBuff_DataServer>.NativeClassPtr, nameof (OffsetAngle));
      SpawnThrowFromBuff_DataServer.NativeFieldInfoPtr_RandomAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnThrowFromBuff_DataServer>.NativeClassPtr, nameof (RandomAngle));
      SpawnThrowFromBuff_DataServer.NativeFieldInfoPtr_NewThrowEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnThrowFromBuff_DataServer>.NativeClassPtr, nameof (NewThrowEntity));
      SpawnThrowFromBuff_DataServer.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnThrowFromBuff_DataServer>.NativeClassPtr, nameof (Count));
      SpawnThrowFromBuff_DataServer.NativeFieldInfoPtr_IndividualRandom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnThrowFromBuff_DataServer>.NativeClassPtr, nameof (IndividualRandom));
      SpawnThrowFromBuff_DataServer.NativeFieldInfoPtr_AlwaysMaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnThrowFromBuff_DataServer>.NativeClassPtr, nameof (AlwaysMaxRange));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnThrowFromBuff_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
