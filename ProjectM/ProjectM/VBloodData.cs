// Decompiled with JetBrains decompiler
// Type: ProjectM.VBloodData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct VBloodData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Level;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    [FieldOffset(0)]
    public int Level;
    [FieldOffset(4)]
    public PrefabGUID PrefabGUID;
    [FieldOffset(8)]
    public LocalizationKey Name;

    static VBloodData()
    {
      Il2CppClassPointerStore<VBloodData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (VBloodData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VBloodData>.NativeClassPtr);
      VBloodData.NativeFieldInfoPtr_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodData>.NativeClassPtr, nameof (Level));
      VBloodData.NativeFieldInfoPtr_PrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodData>.NativeClassPtr, nameof (PrefabGUID));
      VBloodData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodData>.NativeClassPtr, nameof (Name));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VBloodData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
