// Decompiled with JetBrains decompiler
// Type: ProjectM.TickInGroupAttribute
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public class TickInGroupAttribute : Il2CppSystem.Attribute
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TickInGroupType;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

    [CallerCount(23)]
    [CachedScanResults(RefRangeStart = 35476, RefRangeEnd = 35499, XrefRangeStart = 35476, XrefRangeEnd = 35499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TickInGroupAttribute(Il2CppSystem.Type groupType)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TickInGroupAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) groupType);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TickInGroupAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TickInGroupAttribute()
    {
      Il2CppClassPointerStore<TickInGroupAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (TickInGroupAttribute));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TickInGroupAttribute>.NativeClassPtr);
      TickInGroupAttribute.NativeFieldInfoPtr_TickInGroupType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TickInGroupAttribute>.NativeClassPtr, nameof (TickInGroupType));
      TickInGroupAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TickInGroupAttribute>.NativeClassPtr, 100663706);
    }

    public TickInGroupAttribute(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppSystem.Type TickInGroupType
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TickInGroupAttribute.NativeFieldInfoPtr_TickInGroupType));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Type) null : new Il2CppSystem.Type(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TickInGroupAttribute.NativeFieldInfoPtr_TickInGroupType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
