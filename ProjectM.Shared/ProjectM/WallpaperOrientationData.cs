// Decompiled with JetBrains decompiler
// Type: ProjectM.WallpaperOrientationData
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
  [StructLayout(LayoutKind.Explicit)]
  public struct WallpaperOrientationData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Default;
    private static readonly System.IntPtr NativeFieldInfoPtr_StyleIndices;
    private static readonly System.IntPtr NativeFieldInfoPtr_VariationIndices;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_WallpaperOrientationData_0;
    [FieldOffset(0)]
    public WallpaperOrientationData.Indices StyleIndices;
    [FieldOffset(2)]
    public WallpaperOrientationData.Indices VariationIndices;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765809, XrefRangeEnd = 765811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WallpaperOrientationData.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765811, XrefRangeEnd = 765816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WallpaperOrientationData.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765816, XrefRangeEnd = 765817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(WallpaperOrientationData other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WallpaperOrientationData.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_WallpaperOrientationData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static WallpaperOrientationData()
    {
      Il2CppClassPointerStore<WallpaperOrientationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (WallpaperOrientationData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WallpaperOrientationData>.NativeClassPtr);
      WallpaperOrientationData.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallpaperOrientationData>.NativeClassPtr, nameof (Default));
      WallpaperOrientationData.NativeFieldInfoPtr_StyleIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallpaperOrientationData>.NativeClassPtr, nameof (StyleIndices));
      WallpaperOrientationData.NativeFieldInfoPtr_VariationIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallpaperOrientationData>.NativeClassPtr, nameof (VariationIndices));
      WallpaperOrientationData.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallpaperOrientationData>.NativeClassPtr, 100667662);
      WallpaperOrientationData.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallpaperOrientationData>.NativeClassPtr, 100667663);
      WallpaperOrientationData.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_WallpaperOrientationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallpaperOrientationData>.NativeClassPtr, 100667664);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WallpaperOrientationData>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe WallpaperOrientationData Default
    {
      get
      {
        WallpaperOrientationData wallpaperOrientationData;
        IL2CPP.il2cpp_field_static_get_value(WallpaperOrientationData.NativeFieldInfoPtr_Default, (void*) &wallpaperOrientationData);
        return wallpaperOrientationData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(WallpaperOrientationData.NativeFieldInfoPtr_Default, (void*) &value);
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Indices
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Default;
      private static readonly System.IntPtr NativeFieldInfoPtr_Active;
      private static readonly System.IntPtr NativeFieldInfoPtr_Current;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Indices_0;
      [FieldOffset(0)]
      public byte Active;
      [FieldOffset(1)]
      public byte Current;

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 765798, RefRangeEnd = 765800, XrefRangeStart = 765796, XrefRangeEnd = 765798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe int GetHashCode()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WallpaperOrientationData.Indices.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765800, XrefRangeEnd = 765805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(Il2CppSystem.Object obj)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WallpaperOrientationData.Indices.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 765806, RefRangeEnd = 765809, XrefRangeStart = 765805, XrefRangeEnd = 765806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(WallpaperOrientationData.Indices other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WallpaperOrientationData.Indices.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Indices_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static Indices()
      {
        Il2CppClassPointerStore<WallpaperOrientationData.Indices>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WallpaperOrientationData>.NativeClassPtr, nameof (Indices));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WallpaperOrientationData.Indices>.NativeClassPtr);
        WallpaperOrientationData.Indices.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallpaperOrientationData.Indices>.NativeClassPtr, nameof (Default));
        WallpaperOrientationData.Indices.NativeFieldInfoPtr_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallpaperOrientationData.Indices>.NativeClassPtr, nameof (Active));
        WallpaperOrientationData.Indices.NativeFieldInfoPtr_Current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallpaperOrientationData.Indices>.NativeClassPtr, nameof (Current));
        WallpaperOrientationData.Indices.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallpaperOrientationData.Indices>.NativeClassPtr, 100667666);
        WallpaperOrientationData.Indices.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallpaperOrientationData.Indices>.NativeClassPtr, 100667667);
        WallpaperOrientationData.Indices.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Indices_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallpaperOrientationData.Indices>.NativeClassPtr, 100667668);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WallpaperOrientationData.Indices>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe WallpaperOrientationData.Indices Default
      {
        get
        {
          WallpaperOrientationData.Indices indices;
          IL2CPP.il2cpp_field_static_get_value(WallpaperOrientationData.Indices.NativeFieldInfoPtr_Default, (void*) &indices);
          return indices;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(WallpaperOrientationData.Indices.NativeFieldInfoPtr_Default, (void*) &value);
        }
      }
    }
  }
}
