// Decompiled with JetBrains decompiler
// Type: ProjectM.ItemConstants
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
  public class ItemConstants : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MAXTIER;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ItemConstants()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemConstants>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ItemConstants.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ItemConstants()
    {
      Il2CppClassPointerStore<ItemConstants>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ItemConstants));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemConstants>.NativeClassPtr);
      ItemConstants.NativeFieldInfoPtr_MAXTIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemConstants>.NativeClassPtr, nameof (MAXTIER));
      ItemConstants.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemConstants>.NativeClassPtr, 100664052);
    }

    public ItemConstants(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int MAXTIER
    {
      get
      {
        int maxtier;
        IL2CPP.il2cpp_field_static_get_value(ItemConstants.NativeFieldInfoPtr_MAXTIER, (void*) &maxtier);
        return maxtier;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ItemConstants.NativeFieldInfoPtr_MAXTIER, (void*) &value);
      }
    }
  }
}
