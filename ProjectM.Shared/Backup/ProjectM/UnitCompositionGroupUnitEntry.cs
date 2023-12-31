// Decompiled with JetBrains decompiler
// Type: ProjectM.UnitCompositionGroupUnitEntry
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UnitCompositionGroupUnitEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Unit;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsVBloodUnit;
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomVBloodUnit;
    [FieldOffset(0)]
    public PrefabGUID Unit;
    [FieldOffset(4)]
    public bool IsVBloodUnit;
    [FieldOffset(8)]
    public PrefabGUID CustomVBloodUnit;

    static UnitCompositionGroupUnitEntry()
    {
      Il2CppClassPointerStore<UnitCompositionGroupUnitEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (UnitCompositionGroupUnitEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitCompositionGroupUnitEntry>.NativeClassPtr);
      UnitCompositionGroupUnitEntry.NativeFieldInfoPtr_Unit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionGroupUnitEntry>.NativeClassPtr, nameof (Unit));
      UnitCompositionGroupUnitEntry.NativeFieldInfoPtr_IsVBloodUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionGroupUnitEntry>.NativeClassPtr, nameof (IsVBloodUnit));
      UnitCompositionGroupUnitEntry.NativeFieldInfoPtr_CustomVBloodUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionGroupUnitEntry>.NativeClassPtr, nameof (CustomVBloodUnit));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitCompositionGroupUnitEntry>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
