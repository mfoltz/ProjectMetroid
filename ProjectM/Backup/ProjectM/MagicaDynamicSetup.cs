// Decompiled with JetBrains decompiler
// Type: ProjectM.MagicaDynamicSetup
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using MagicaCloth;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public sealed class MagicaDynamicSetup : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BoneCloth;
    private static readonly System.IntPtr NativeFieldInfoPtr_MeshCloth;
    private static readonly System.IntPtr NativeFieldInfoPtr_CollisionSet;

    static MagicaDynamicSetup()
    {
      Il2CppClassPointerStore<MagicaDynamicSetup>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (MagicaDynamicSetup));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MagicaDynamicSetup>.NativeClassPtr);
      MagicaDynamicSetup.NativeFieldInfoPtr_BoneCloth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MagicaDynamicSetup>.NativeClassPtr, nameof (BoneCloth));
      MagicaDynamicSetup.NativeFieldInfoPtr_MeshCloth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MagicaDynamicSetup>.NativeClassPtr, nameof (MeshCloth));
      MagicaDynamicSetup.NativeFieldInfoPtr_CollisionSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MagicaDynamicSetup>.NativeClassPtr, nameof (CollisionSet));
    }

    public MagicaDynamicSetup(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public MagicaDynamicSetup()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MagicaDynamicSetup>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MagicaDynamicSetup>.NativeClassPtr, data));
    }

    public unsafe MagicaBoneCloth BoneCloth
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MagicaDynamicSetup.NativeFieldInfoPtr_BoneCloth));
        return pointer == System.IntPtr.Zero ? (MagicaBoneCloth) null : new MagicaBoneCloth(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MagicaDynamicSetup.NativeFieldInfoPtr_BoneCloth), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MagicaMeshCloth MeshCloth
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MagicaDynamicSetup.NativeFieldInfoPtr_MeshCloth));
        return pointer == System.IntPtr.Zero ? (MagicaMeshCloth) null : new MagicaMeshCloth(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MagicaDynamicSetup.NativeFieldInfoPtr_MeshCloth), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BodyPartColliderUseSet CollisionSet
    {
      get
      {
        return *(BodyPartColliderUseSet*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MagicaDynamicSetup.NativeFieldInfoPtr_CollisionSet));
      }
      [param: In] set
      {
        *(BodyPartColliderUseSet*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MagicaDynamicSetup.NativeFieldInfoPtr_CollisionSet)) = value;
      }
    }
  }
}
