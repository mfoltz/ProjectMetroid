// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.TextureStreamingListSharedComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Presentation
{
  public sealed class TextureStreamingListSharedComponent : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Textures;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TextureStreamingListSharedComponent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 358372, RefRangeEnd = 358382, XrefRangeStart = 358372, XrefRangeEnd = 358382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(TextureStreamingListSharedComponent other)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other));
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TextureStreamingListSharedComponent.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TextureStreamingListSharedComponent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public override unsafe int GetHashCode()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TextureStreamingListSharedComponent.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TextureStreamingListSharedComponent()
    {
      Il2CppClassPointerStore<TextureStreamingListSharedComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation", nameof (TextureStreamingListSharedComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureStreamingListSharedComponent>.NativeClassPtr);
      TextureStreamingListSharedComponent.NativeFieldInfoPtr_Textures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureStreamingListSharedComponent>.NativeClassPtr, nameof (Textures));
      TextureStreamingListSharedComponent.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TextureStreamingListSharedComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureStreamingListSharedComponent>.NativeClassPtr, 100688120);
      TextureStreamingListSharedComponent.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureStreamingListSharedComponent>.NativeClassPtr, 100688121);
    }

    public TextureStreamingListSharedComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public TextureStreamingListSharedComponent()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextureStreamingListSharedComponent>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextureStreamingListSharedComponent>.NativeClassPtr, data));
    }

    public unsafe List<Texture2D> Textures
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextureStreamingListSharedComponent.NativeFieldInfoPtr_Textures));
        return pointer == System.IntPtr.Zero ? (List<Texture2D>) null : new List<Texture2D>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TextureStreamingListSharedComponent.NativeFieldInfoPtr_Textures), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
