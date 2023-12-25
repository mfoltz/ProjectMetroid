// Decompiled with JetBrains decompiler
// Type: ProjectM.VBloodConsumed
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct VBloodConsumed
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Source;
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    [FieldOffset(0)]
    public PrefabGUID Source;
    [FieldOffset(4)]
    public Entity Target;

    static VBloodConsumed()
    {
      Il2CppClassPointerStore<VBloodConsumed>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (VBloodConsumed));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VBloodConsumed>.NativeClassPtr);
      VBloodConsumed.NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodConsumed>.NativeClassPtr, nameof (Source));
      VBloodConsumed.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodConsumed>.NativeClassPtr, nameof (Target));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VBloodConsumed>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
