// Decompiled with JetBrains decompiler
// Type: ProjectM.Residency
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Residency
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_InsideBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_Resident;
    [FieldOffset(0)]
    public PrefabGUID InsideBuff;
    [FieldOffset(4)]
    public Entity Resident;

    static Residency()
    {
      Il2CppClassPointerStore<Residency>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (Residency));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Residency>.NativeClassPtr);
      Residency.NativeFieldInfoPtr_InsideBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Residency>.NativeClassPtr, nameof (InsideBuff));
      Residency.NativeFieldInfoPtr_Resident = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Residency>.NativeClassPtr, nameof (Resident));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Residency>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
