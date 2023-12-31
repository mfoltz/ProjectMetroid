// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.SwapArtWhileRaided
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.CastleBuilding
{
  public sealed class SwapArtWhileRaided : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_OverrideMaterial;
    private static readonly System.IntPtr NativeFieldInfoPtr_OriginalMaterial;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SwapArtWhileRaided_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(SwapArtWhileRaided other)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other));
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SwapArtWhileRaided.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SwapArtWhileRaided_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794116, XrefRangeEnd = 794121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool Equals(Il2CppSystem.Object obj)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SwapArtWhileRaided.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794121, XrefRangeEnd = 794129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SwapArtWhileRaided.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SwapArtWhileRaided()
    {
      Il2CppClassPointerStore<SwapArtWhileRaided>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.CastleBuilding", nameof (SwapArtWhileRaided));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SwapArtWhileRaided>.NativeClassPtr);
      SwapArtWhileRaided.NativeFieldInfoPtr_OverrideMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwapArtWhileRaided>.NativeClassPtr, nameof (OverrideMaterial));
      SwapArtWhileRaided.NativeFieldInfoPtr_OriginalMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwapArtWhileRaided>.NativeClassPtr, nameof (OriginalMaterial));
      SwapArtWhileRaided.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SwapArtWhileRaided_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwapArtWhileRaided>.NativeClassPtr, 100670005);
      SwapArtWhileRaided.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwapArtWhileRaided>.NativeClassPtr, 100670006);
      SwapArtWhileRaided.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwapArtWhileRaided>.NativeClassPtr, 100670007);
    }

    public SwapArtWhileRaided(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public SwapArtWhileRaided()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SwapArtWhileRaided>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SwapArtWhileRaided>.NativeClassPtr, data));
    }

    public unsafe Material OverrideMaterial
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwapArtWhileRaided.NativeFieldInfoPtr_OverrideMaterial));
        return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SwapArtWhileRaided.NativeFieldInfoPtr_OverrideMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Material OriginalMaterial
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwapArtWhileRaided.NativeFieldInfoPtr_OriginalMaterial));
        return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SwapArtWhileRaided.NativeFieldInfoPtr_OriginalMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
