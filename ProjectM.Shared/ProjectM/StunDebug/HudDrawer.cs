// Decompiled with JetBrains decompiler
// Type: ProjectM.StunDebug.HudDrawer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.StunDebug
{
  public class HudDrawer : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Canvas;
    private static readonly System.IntPtr NativeFieldInfoPtr__StringsToDraw;
    private static readonly System.IntPtr NativeFieldInfoPtr__StringsThatDidntFoundOld;
    private static readonly System.IntPtr NativeFieldInfoPtr__TextPool;
    private static readonly System.IntPtr NativeFieldInfoPtr__UsedTexts;
    private static readonly System.IntPtr NativeFieldInfoPtr__OneShotStrings;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_Camera_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ActivateAndSetData_Private_Static_Void_Text_byref_StringData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReturnToPool_Private_Void_Text_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AllocateNewText_Private_Text_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawString_Public_Void_Vector3_String_Color_ViewSpace_Int32_Nullable_Unboxed_1_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawStringOneShot_Public_Void_Vector3_Vector3_String_Color_Single_ViewSpace_Int32_Nullable_Unboxed_1_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 771266, RefRangeEnd = 771267, XrefRangeStart = 771109, XrefRangeEnd = 771266, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update(Camera camera)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HudDrawer.NativeMethodInfoPtr_Update_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 771277, RefRangeEnd = 771279, XrefRangeStart = 771267, XrefRangeEnd = 771277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ActivateAndSetData(
      Text textComponent,
      [In] ref HudDrawer.StringData stringData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) textComponent);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) stringData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HudDrawer.NativeMethodInfoPtr_ActivateAndSetData_Private_Static_Void_Text_byref_StringData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 771286, RefRangeEnd = 771288, XrefRangeStart = 771279, XrefRangeEnd = 771286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ReturnToPool(Text textComponent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) textComponent);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HudDrawer.NativeMethodInfoPtr_ReturnToPool_Private_Void_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 771319, RefRangeEnd = 771320, XrefRangeStart = 771288, XrefRangeEnd = 771319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Text AllocateNewText()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HudDrawer.NativeMethodInfoPtr_AllocateNewText_Private_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Text) null : new Text(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 771330, RefRangeEnd = 771331, XrefRangeStart = 771320, XrefRangeEnd = 771330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DrawString(
      Vector3 position,
      string text,
      Color color,
      HudDrawer.ViewSpace viewSpace,
      int fontSize = 20,
      Nullable_Unboxed<Vector2> pivot = default (Nullable_Unboxed<Vector2>))
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(text);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &viewSpace;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &fontSize;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &pivot;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HudDrawer.NativeMethodInfoPtr_DrawString_Public_Void_Vector3_String_Color_ViewSpace_Int32_Nullable_Unboxed_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 771340, RefRangeEnd = 771341, XrefRangeStart = 771331, XrefRangeEnd = 771340, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DrawStringOneShot(
      Vector3 position,
      Vector3 velocity,
      string text,
      Color color,
      float lifetime,
      HudDrawer.ViewSpace viewSpace,
      int fontSize = 20,
      Nullable_Unboxed<Vector2> pivot = default (Nullable_Unboxed<Vector2>))
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &velocity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(text);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &lifetime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &viewSpace;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &fontSize;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &pivot;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HudDrawer.NativeMethodInfoPtr_DrawStringOneShot_Public_Void_Vector3_Vector3_String_Color_Single_ViewSpace_Int32_Nullable_Unboxed_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 771375, RefRangeEnd = 771376, XrefRangeStart = 771341, XrefRangeEnd = 771375, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HudDrawer()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HudDrawer>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HudDrawer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HudDrawer()
    {
      Il2CppClassPointerStore<HudDrawer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.StunDebug", nameof (HudDrawer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HudDrawer>.NativeClassPtr);
      HudDrawer.NativeFieldInfoPtr__Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HudDrawer>.NativeClassPtr, nameof (_Canvas));
      HudDrawer.NativeFieldInfoPtr__StringsToDraw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HudDrawer>.NativeClassPtr, nameof (_StringsToDraw));
      HudDrawer.NativeFieldInfoPtr__StringsThatDidntFoundOld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HudDrawer>.NativeClassPtr, nameof (_StringsThatDidntFoundOld));
      HudDrawer.NativeFieldInfoPtr__TextPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HudDrawer>.NativeClassPtr, nameof (_TextPool));
      HudDrawer.NativeFieldInfoPtr__UsedTexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HudDrawer>.NativeClassPtr, nameof (_UsedTexts));
      HudDrawer.NativeFieldInfoPtr__OneShotStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HudDrawer>.NativeClassPtr, nameof (_OneShotStrings));
      HudDrawer.NativeMethodInfoPtr_Update_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HudDrawer>.NativeClassPtr, 100668317);
      HudDrawer.NativeMethodInfoPtr_ActivateAndSetData_Private_Static_Void_Text_byref_StringData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HudDrawer>.NativeClassPtr, 100668318);
      HudDrawer.NativeMethodInfoPtr_ReturnToPool_Private_Void_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HudDrawer>.NativeClassPtr, 100668319);
      HudDrawer.NativeMethodInfoPtr_AllocateNewText_Private_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HudDrawer>.NativeClassPtr, 100668320);
      HudDrawer.NativeMethodInfoPtr_DrawString_Public_Void_Vector3_String_Color_ViewSpace_Int32_Nullable_Unboxed_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HudDrawer>.NativeClassPtr, 100668321);
      HudDrawer.NativeMethodInfoPtr_DrawStringOneShot_Public_Void_Vector3_Vector3_String_Color_Single_ViewSpace_Int32_Nullable_Unboxed_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HudDrawer>.NativeClassPtr, 100668322);
      HudDrawer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HudDrawer>.NativeClassPtr, 100668323);
    }

    public HudDrawer(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Canvas _Canvas
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.NativeFieldInfoPtr__Canvas));
        return pointer == System.IntPtr.Zero ? (Canvas) null : new Canvas(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.NativeFieldInfoPtr__Canvas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<HudDrawer.StringData> _StringsToDraw
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.NativeFieldInfoPtr__StringsToDraw));
        return pointer == System.IntPtr.Zero ? (List<HudDrawer.StringData>) null : new List<HudDrawer.StringData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.NativeFieldInfoPtr__StringsToDraw), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<HudDrawer.StringData> _StringsThatDidntFoundOld
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.NativeFieldInfoPtr__StringsThatDidntFoundOld));
        return pointer == System.IntPtr.Zero ? (List<HudDrawer.StringData>) null : new List<HudDrawer.StringData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.NativeFieldInfoPtr__StringsThatDidntFoundOld), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<HudDrawer.FreeText> _TextPool
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.NativeFieldInfoPtr__TextPool));
        return pointer == System.IntPtr.Zero ? (List<HudDrawer.FreeText>) null : new List<HudDrawer.FreeText>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.NativeFieldInfoPtr__TextPool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<HudDrawer.UsedText> _UsedTexts
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.NativeFieldInfoPtr__UsedTexts));
        return pointer == System.IntPtr.Zero ? (List<HudDrawer.UsedText>) null : new List<HudDrawer.UsedText>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.NativeFieldInfoPtr__UsedTexts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<HudDrawer.OneShotString> _OneShotStrings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.NativeFieldInfoPtr__OneShotStrings));
        return pointer == System.IntPtr.Zero ? (List<HudDrawer.OneShotString>) null : new List<HudDrawer.OneShotString>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.NativeFieldInfoPtr__OneShotStrings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public enum ViewSpace : byte
    {
      WorldSpace,
      ScreenSpacePixels,
      ScreenSpaceFactor,
    }

    public sealed class StringData : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Position;
      private static readonly System.IntPtr NativeFieldInfoPtr_String;
      private static readonly System.IntPtr NativeFieldInfoPtr_Color;
      private static readonly System.IntPtr NativeFieldInfoPtr_Lifetime;
      private static readonly System.IntPtr NativeFieldInfoPtr_ViewSpace;
      private static readonly System.IntPtr NativeFieldInfoPtr_Velocity;
      private static readonly System.IntPtr NativeFieldInfoPtr_FontSize;
      private static readonly System.IntPtr NativeFieldInfoPtr_Pivot;
      private static readonly System.IntPtr NativeFieldInfoPtr_OneShot;

      static StringData()
      {
        Il2CppClassPointerStore<HudDrawer.StringData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HudDrawer>.NativeClassPtr, nameof (StringData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HudDrawer.StringData>.NativeClassPtr);
        HudDrawer.StringData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HudDrawer.StringData>.NativeClassPtr, nameof (Position));
        HudDrawer.StringData.NativeFieldInfoPtr_String = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HudDrawer.StringData>.NativeClassPtr, nameof (String));
        HudDrawer.StringData.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HudDrawer.StringData>.NativeClassPtr, nameof (Color));
        HudDrawer.StringData.NativeFieldInfoPtr_Lifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HudDrawer.StringData>.NativeClassPtr, nameof (Lifetime));
        HudDrawer.StringData.NativeFieldInfoPtr_ViewSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HudDrawer.StringData>.NativeClassPtr, nameof (ViewSpace));
        HudDrawer.StringData.NativeFieldInfoPtr_Velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HudDrawer.StringData>.NativeClassPtr, nameof (Velocity));
        HudDrawer.StringData.NativeFieldInfoPtr_FontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HudDrawer.StringData>.NativeClassPtr, nameof (FontSize));
        HudDrawer.StringData.NativeFieldInfoPtr_Pivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HudDrawer.StringData>.NativeClassPtr, nameof (Pivot));
        HudDrawer.StringData.NativeFieldInfoPtr_OneShot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HudDrawer.StringData>.NativeClassPtr, nameof (OneShot));
      }

      public StringData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public StringData()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HudDrawer.StringData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HudDrawer.StringData>.NativeClassPtr, data));
      }

      public unsafe Vector3 Position
      {
        get
        {
          return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.StringData.NativeFieldInfoPtr_Position));
        }
        [param: In] set
        {
          *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.StringData.NativeFieldInfoPtr_Position)) = value;
        }
      }

      public unsafe string String
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.StringData.NativeFieldInfoPtr_String)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.StringData.NativeFieldInfoPtr_String), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe Color Color
      {
        get
        {
          return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.StringData.NativeFieldInfoPtr_Color));
        }
        [param: In] set
        {
          *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.StringData.NativeFieldInfoPtr_Color)) = value;
        }
      }

      public unsafe float Lifetime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.StringData.NativeFieldInfoPtr_Lifetime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.StringData.NativeFieldInfoPtr_Lifetime)) = value;
        }
      }

      public unsafe HudDrawer.ViewSpace ViewSpace
      {
        get
        {
          return *(HudDrawer.ViewSpace*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.StringData.NativeFieldInfoPtr_ViewSpace));
        }
        [param: In] set
        {
          *(HudDrawer.ViewSpace*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.StringData.NativeFieldInfoPtr_ViewSpace)) = value;
        }
      }

      public unsafe Vector3 Velocity
      {
        get
        {
          return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.StringData.NativeFieldInfoPtr_Velocity));
        }
        [param: In] set
        {
          *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.StringData.NativeFieldInfoPtr_Velocity)) = value;
        }
      }

      public unsafe int FontSize
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.StringData.NativeFieldInfoPtr_FontSize));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.StringData.NativeFieldInfoPtr_FontSize)) = value;
        }
      }

      public unsafe Vector2 Pivot
      {
        get
        {
          return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.StringData.NativeFieldInfoPtr_Pivot));
        }
        [param: In] set
        {
          *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.StringData.NativeFieldInfoPtr_Pivot)) = value;
        }
      }

      public unsafe bool OneShot
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.StringData.NativeFieldInfoPtr_OneShot));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.StringData.NativeFieldInfoPtr_OneShot)) = value;
        }
      }
    }

    public sealed class FreeText : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_CurrentText;
      private static readonly System.IntPtr NativeFieldInfoPtr_TextComponent;

      static FreeText()
      {
        Il2CppClassPointerStore<HudDrawer.FreeText>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HudDrawer>.NativeClassPtr, nameof (FreeText));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HudDrawer.FreeText>.NativeClassPtr);
        HudDrawer.FreeText.NativeFieldInfoPtr_CurrentText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HudDrawer.FreeText>.NativeClassPtr, nameof (CurrentText));
        HudDrawer.FreeText.NativeFieldInfoPtr_TextComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HudDrawer.FreeText>.NativeClassPtr, nameof (TextComponent));
      }

      public FreeText(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public FreeText()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HudDrawer.FreeText>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HudDrawer.FreeText>.NativeClassPtr, data));
      }

      public unsafe string CurrentText
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.FreeText.NativeFieldInfoPtr_CurrentText)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.FreeText.NativeFieldInfoPtr_CurrentText), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe Text TextComponent
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.FreeText.NativeFieldInfoPtr_TextComponent));
          return pointer == System.IntPtr.Zero ? (Text) null : new Text(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.FreeText.NativeFieldInfoPtr_TextComponent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    public sealed class UsedText : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_StringData;
      private static readonly System.IntPtr NativeFieldInfoPtr_TextComponent;

      static UsedText()
      {
        Il2CppClassPointerStore<HudDrawer.UsedText>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HudDrawer>.NativeClassPtr, nameof (UsedText));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HudDrawer.UsedText>.NativeClassPtr);
        HudDrawer.UsedText.NativeFieldInfoPtr_StringData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HudDrawer.UsedText>.NativeClassPtr, nameof (StringData));
        HudDrawer.UsedText.NativeFieldInfoPtr_TextComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HudDrawer.UsedText>.NativeClassPtr, nameof (TextComponent));
      }

      public UsedText(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public UsedText()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HudDrawer.UsedText>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HudDrawer.UsedText>.NativeClassPtr, data));
      }

      public HudDrawer.StringData StringData
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.UsedText.NativeFieldInfoPtr_StringData);
          return new HudDrawer.StringData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HudDrawer.StringData>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.UsedText.NativeFieldInfoPtr_StringData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HudDrawer.StringData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe Text TextComponent
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.UsedText.NativeFieldInfoPtr_TextComponent));
          return pointer == System.IntPtr.Zero ? (Text) null : new Text(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.UsedText.NativeFieldInfoPtr_TextComponent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    public sealed class OneShotString : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_StringData;
      private static readonly System.IntPtr NativeFieldInfoPtr_TextComponent;
      private static readonly System.IntPtr NativeFieldInfoPtr_CanvasRenderer;
      private static readonly System.IntPtr NativeFieldInfoPtr_TimeSpawned;

      static OneShotString()
      {
        Il2CppClassPointerStore<HudDrawer.OneShotString>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HudDrawer>.NativeClassPtr, nameof (OneShotString));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HudDrawer.OneShotString>.NativeClassPtr);
        HudDrawer.OneShotString.NativeFieldInfoPtr_StringData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HudDrawer.OneShotString>.NativeClassPtr, nameof (StringData));
        HudDrawer.OneShotString.NativeFieldInfoPtr_TextComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HudDrawer.OneShotString>.NativeClassPtr, nameof (TextComponent));
        HudDrawer.OneShotString.NativeFieldInfoPtr_CanvasRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HudDrawer.OneShotString>.NativeClassPtr, nameof (CanvasRenderer));
        HudDrawer.OneShotString.NativeFieldInfoPtr_TimeSpawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HudDrawer.OneShotString>.NativeClassPtr, nameof (TimeSpawned));
      }

      public OneShotString(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public OneShotString()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HudDrawer.OneShotString>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HudDrawer.OneShotString>.NativeClassPtr, data));
      }

      public HudDrawer.StringData StringData
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.OneShotString.NativeFieldInfoPtr_StringData);
          return new HudDrawer.StringData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HudDrawer.StringData>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.OneShotString.NativeFieldInfoPtr_StringData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HudDrawer.StringData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe Text TextComponent
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.OneShotString.NativeFieldInfoPtr_TextComponent));
          return pointer == System.IntPtr.Zero ? (Text) null : new Text(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.OneShotString.NativeFieldInfoPtr_TextComponent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe CanvasRenderer CanvasRenderer
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.OneShotString.NativeFieldInfoPtr_CanvasRenderer));
          return pointer == System.IntPtr.Zero ? (CanvasRenderer) null : new CanvasRenderer(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.OneShotString.NativeFieldInfoPtr_CanvasRenderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe float TimeSpawned
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.OneShotString.NativeFieldInfoPtr_TimeSpawned));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HudDrawer.OneShotString.NativeFieldInfoPtr_TimeSpawned)) = value;
        }
      }
    }
  }
}
