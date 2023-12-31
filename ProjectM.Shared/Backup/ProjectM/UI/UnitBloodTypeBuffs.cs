// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.UnitBloodTypeBuffs
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UnitBloodTypeBuffs
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinQuality;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffType;
    [FieldOffset(0)]
    public float MinQuality;
    [FieldOffset(4)]
    public PrefabGUID BuffType;

    static UnitBloodTypeBuffs()
    {
      Il2CppClassPointerStore<UnitBloodTypeBuffs>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.UI", nameof (UnitBloodTypeBuffs));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitBloodTypeBuffs>.NativeClassPtr);
      UnitBloodTypeBuffs.NativeFieldInfoPtr_MinQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitBloodTypeBuffs>.NativeClassPtr, nameof (MinQuality));
      UnitBloodTypeBuffs.NativeFieldInfoPtr_BuffType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitBloodTypeBuffs>.NativeClassPtr, nameof (BuffType));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitBloodTypeBuffs>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
