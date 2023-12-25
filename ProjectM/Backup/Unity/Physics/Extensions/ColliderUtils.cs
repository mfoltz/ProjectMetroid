// Decompiled with JetBrains decompiler
// Type: Unity.Physics.Extensions.ColliderUtils
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Unity.Entities;

#nullable disable
namespace Unity.Physics.Extensions
{
  public class ColliderUtils : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_IsTrigger_Public_Static_Boolean_BlobAssetReference_1_Collider_ColliderKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 926155, RefRangeEnd = 926156, XrefRangeStart = 926141, XrefRangeEnd = 926155, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsTrigger(BlobAssetReference<Collider> collider, ColliderKey key)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &collider;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &key;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ColliderUtils.NativeMethodInfoPtr_IsTrigger_Public_Static_Boolean_BlobAssetReference_1_Collider_ColliderKey_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ColliderUtils()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColliderUtils>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ColliderUtils.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ColliderUtils()
    {
      Il2CppClassPointerStore<ColliderUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Physics.Extensions", nameof (ColliderUtils));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColliderUtils>.NativeClassPtr);
      ColliderUtils.NativeMethodInfoPtr_IsTrigger_Public_Static_Boolean_BlobAssetReference_1_Collider_ColliderKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderUtils>.NativeClassPtr, 100663983);
      ColliderUtils.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderUtils>.NativeClassPtr, 100663984);
    }

    public ColliderUtils(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
