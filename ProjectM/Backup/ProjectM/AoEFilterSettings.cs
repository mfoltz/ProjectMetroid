// Decompiled with JetBrains decompiler
// Type: ProjectM.AoEFilterSettings
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct AoEFilterSettings
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Near_Origin_Factor;
    private static readonly System.IntPtr NativeFieldInfoPtr_Near_Origin_Distance;
    private static readonly System.IntPtr NativeFieldInfoPtr_Target_Priority_Factor;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseMeleeCone;
    private static readonly System.IntPtr NativeFieldInfoPtr_Melee_Cone_Angle;
    [FieldOffset(0)]
    public float Near_Origin_Factor;
    [FieldOffset(4)]
    public float Near_Origin_Distance;
    [FieldOffset(8)]
    public float Target_Priority_Factor;
    [FieldOffset(12)]
    public bool UseMeleeCone;
    [FieldOffset(16)]
    public float Melee_Cone_Angle;

    static AoEFilterSettings()
    {
      Il2CppClassPointerStore<AoEFilterSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AoEFilterSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AoEFilterSettings>.NativeClassPtr);
      AoEFilterSettings.NativeFieldInfoPtr_Near_Origin_Factor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AoEFilterSettings>.NativeClassPtr, nameof (Near_Origin_Factor));
      AoEFilterSettings.NativeFieldInfoPtr_Near_Origin_Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AoEFilterSettings>.NativeClassPtr, nameof (Near_Origin_Distance));
      AoEFilterSettings.NativeFieldInfoPtr_Target_Priority_Factor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AoEFilterSettings>.NativeClassPtr, nameof (Target_Priority_Factor));
      AoEFilterSettings.NativeFieldInfoPtr_UseMeleeCone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AoEFilterSettings>.NativeClassPtr, nameof (UseMeleeCone));
      AoEFilterSettings.NativeFieldInfoPtr_Melee_Cone_Angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AoEFilterSettings>.NativeClassPtr, nameof (Melee_Cone_Angle));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AoEFilterSettings>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
