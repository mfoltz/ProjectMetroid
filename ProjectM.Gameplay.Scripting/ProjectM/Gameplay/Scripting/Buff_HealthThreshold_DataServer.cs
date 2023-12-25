// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Buff_HealthThreshold_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Buff_HealthThreshold_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NewBuffEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_HealthFactor1;
    private static readonly System.IntPtr NativeFieldInfoPtr_HealthFactor2;
    private static readonly System.IntPtr NativeFieldInfoPtr_HealthFactor3;
    private static readonly System.IntPtr NativeFieldInfoPtr_Threshold1Met;
    private static readonly System.IntPtr NativeFieldInfoPtr_Threshold2Met;
    private static readonly System.IntPtr NativeFieldInfoPtr_Threshold3Met;
    [FieldOffset(0)]
    public PrefabGUID NewBuffEntity;
    [FieldOffset(4)]
    public float HealthFactor1;
    [FieldOffset(8)]
    public float HealthFactor2;
    [FieldOffset(12)]
    public float HealthFactor3;
    [FieldOffset(16)]
    public bool Threshold1Met;
    [FieldOffset(17)]
    public bool Threshold2Met;
    [FieldOffset(18)]
    public bool Threshold3Met;

    static Buff_HealthThreshold_DataServer()
    {
      Il2CppClassPointerStore<Buff_HealthThreshold_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Buff_HealthThreshold_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Buff_HealthThreshold_DataServer>.NativeClassPtr);
      Buff_HealthThreshold_DataServer.NativeFieldInfoPtr_NewBuffEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff_HealthThreshold_DataServer>.NativeClassPtr, nameof (NewBuffEntity));
      Buff_HealthThreshold_DataServer.NativeFieldInfoPtr_HealthFactor1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff_HealthThreshold_DataServer>.NativeClassPtr, nameof (HealthFactor1));
      Buff_HealthThreshold_DataServer.NativeFieldInfoPtr_HealthFactor2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff_HealthThreshold_DataServer>.NativeClassPtr, nameof (HealthFactor2));
      Buff_HealthThreshold_DataServer.NativeFieldInfoPtr_HealthFactor3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff_HealthThreshold_DataServer>.NativeClassPtr, nameof (HealthFactor3));
      Buff_HealthThreshold_DataServer.NativeFieldInfoPtr_Threshold1Met = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff_HealthThreshold_DataServer>.NativeClassPtr, nameof (Threshold1Met));
      Buff_HealthThreshold_DataServer.NativeFieldInfoPtr_Threshold2Met = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff_HealthThreshold_DataServer>.NativeClassPtr, nameof (Threshold2Met));
      Buff_HealthThreshold_DataServer.NativeFieldInfoPtr_Threshold3Met = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff_HealthThreshold_DataServer>.NativeClassPtr, nameof (Threshold3Met));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Buff_HealthThreshold_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
