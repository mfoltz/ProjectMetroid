// Decompiled with JetBrains decompiler
// Type: ProjectM.ManagedItemSet
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public class ManagedItemSet : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabName;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemSetEntries;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(4981)]
    [CachedScanResults(RefRangeStart = 10610, RefRangeEnd = 15591, XrefRangeStart = 10610, XrefRangeEnd = 15591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.Object System_ICloneable_Clone()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ManagedItemSet.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ManagedItemSet()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagedItemSet>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ManagedItemSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ManagedItemSet()
    {
      Il2CppClassPointerStore<ManagedItemSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ManagedItemSet));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagedItemSet>.NativeClassPtr);
      ManagedItemSet.NativeFieldInfoPtr_PrefabName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedItemSet>.NativeClassPtr, nameof (PrefabName));
      ManagedItemSet.NativeFieldInfoPtr_ItemSetEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedItemSet>.NativeClassPtr, nameof (ItemSetEntries));
      ManagedItemSet.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedItemSet>.NativeClassPtr, 100664332);
      ManagedItemSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedItemSet>.NativeClassPtr, 100664333);
    }

    public ManagedItemSet(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string PrefabName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedItemSet.NativeFieldInfoPtr_PrefabName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ManagedItemSet.NativeFieldInfoPtr_PrefabName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe List<ItemSetEntry> ItemSetEntries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedItemSet.NativeFieldInfoPtr_ItemSetEntries));
        return pointer == System.IntPtr.Zero ? (List<ItemSetEntry>) null : new List<ItemSetEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ManagedItemSet.NativeFieldInfoPtr_ItemSetEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
