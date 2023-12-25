// Decompiled with JetBrains decompiler
// Type: ProjectM.PerkData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PerkData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LootValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_PowerValue;
    [FieldOffset(0)]
    public float LootValue;
    [FieldOffset(4)]
    public PrefabGUID PrefabGUID;
    [FieldOffset(8)]
    public int PowerValue;

    static PerkData()
    {
      Il2CppClassPointerStore<PerkData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (PerkData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PerkData>.NativeClassPtr);
      PerkData.NativeFieldInfoPtr_LootValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerkData>.NativeClassPtr, nameof (LootValue));
      PerkData.NativeFieldInfoPtr_PrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerkData>.NativeClassPtr, nameof (PrefabGUID));
      PerkData.NativeFieldInfoPtr_PowerValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerkData>.NativeClassPtr, nameof (PowerValue));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PerkData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
