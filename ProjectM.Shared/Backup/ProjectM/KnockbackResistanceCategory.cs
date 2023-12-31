// Decompiled with JetBrains decompiler
// Type: ProjectM.KnockbackResistanceCategory
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public sealed class KnockbackResistanceCategory : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Guid;

    static KnockbackResistanceCategory()
    {
      Il2CppClassPointerStore<KnockbackResistanceCategory>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (KnockbackResistanceCategory));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KnockbackResistanceCategory>.NativeClassPtr);
      KnockbackResistanceCategory.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackResistanceCategory>.NativeClassPtr, nameof (Guid));
    }

    public KnockbackResistanceCategory(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public KnockbackResistanceCategory()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KnockbackResistanceCategory>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KnockbackResistanceCategory>.NativeClassPtr, data));
    }

    public unsafe string Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KnockbackResistanceCategory.NativeFieldInfoPtr_Guid)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(KnockbackResistanceCategory.NativeFieldInfoPtr_Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
