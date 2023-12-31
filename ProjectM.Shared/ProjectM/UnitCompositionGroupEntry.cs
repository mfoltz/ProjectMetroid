// Decompiled with JetBrains decompiler
// Type: ProjectM.UnitCompositionGroupEntry
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UnitCompositionGroupEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeRequirement;
    private static readonly System.IntPtr NativeFieldInfoPtr_Id;
    private static readonly System.IntPtr NativeFieldInfoPtr_Weight;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitsStartIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitsCount;
    [FieldOffset(0)]
    public PrefabGUID TimeRequirement;
    [FieldOffset(4)]
    public UnitCompositionId Id;
    [FieldOffset(8)]
    public int Weight;
    [FieldOffset(12)]
    public int UnitsStartIndex;
    [FieldOffset(16)]
    public int UnitsCount;

    static UnitCompositionGroupEntry()
    {
      Il2CppClassPointerStore<UnitCompositionGroupEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (UnitCompositionGroupEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitCompositionGroupEntry>.NativeClassPtr);
      UnitCompositionGroupEntry.NativeFieldInfoPtr_TimeRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionGroupEntry>.NativeClassPtr, nameof (TimeRequirement));
      UnitCompositionGroupEntry.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionGroupEntry>.NativeClassPtr, nameof (Id));
      UnitCompositionGroupEntry.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionGroupEntry>.NativeClassPtr, nameof (Weight));
      UnitCompositionGroupEntry.NativeFieldInfoPtr_UnitsStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionGroupEntry>.NativeClassPtr, nameof (UnitsStartIndex));
      UnitCompositionGroupEntry.NativeFieldInfoPtr_UnitsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionGroupEntry>.NativeClassPtr, nameof (UnitsCount));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitCompositionGroupEntry>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
