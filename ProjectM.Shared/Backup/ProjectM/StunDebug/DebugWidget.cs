// Decompiled with JetBrains decompiler
// Type: ProjectM.StunDebug.DebugWidget
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.StunDebug
{
  public class DebugWidget : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__LineMaterial;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastTimeUsed;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LineMaterial_Protected_Static_get_Material_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawInWorld_Public_Virtual_New_Void_Camera_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawOnScreen_Public_Virtual_New_Rect_Rect_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

    public static unsafe Material LineMaterial
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 772005, RefRangeEnd = 772014, XrefRangeStart = 771989, XrefRangeEnd = 772005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugWidget.NativeMethodInfoPtr_get_LineMaterial_Protected_Static_get_Material_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
      }
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void DrawInWorld(Camera camera)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DebugWidget.NativeMethodInfoPtr_DrawInWorld_Public_Virtual_New_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(54)]
    [CachedScanResults(RefRangeStart = 533439, RefRangeEnd = 533493, XrefRangeStart = 533439, XrefRangeEnd = 533493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Rect DrawOnScreen(Rect rect, float z)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &rect;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &z;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DebugWidget.NativeMethodInfoPtr_DrawOnScreen_Public_Virtual_New_Rect_Rect_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Rect*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DebugWidget()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugWidget>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugWidget.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DebugWidget()
    {
      Il2CppClassPointerStore<DebugWidget>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.StunDebug", nameof (DebugWidget));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugWidget>.NativeClassPtr);
      DebugWidget.NativeFieldInfoPtr__LineMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugWidget>.NativeClassPtr, nameof (_LineMaterial));
      DebugWidget.NativeFieldInfoPtr_LastTimeUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugWidget>.NativeClassPtr, nameof (LastTimeUsed));
      DebugWidget.NativeMethodInfoPtr_get_LineMaterial_Protected_Static_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugWidget>.NativeClassPtr, 100668359);
      DebugWidget.NativeMethodInfoPtr_DrawInWorld_Public_Virtual_New_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugWidget>.NativeClassPtr, 100668360);
      DebugWidget.NativeMethodInfoPtr_DrawOnScreen_Public_Virtual_New_Rect_Rect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugWidget>.NativeClassPtr, 100668361);
      DebugWidget.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugWidget>.NativeClassPtr, 100668362);
    }

    public DebugWidget(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe Material _LineMaterial
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(DebugWidget.NativeFieldInfoPtr__LineMaterial, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DebugWidget.NativeFieldInfoPtr__LineMaterial, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float LastTimeUsed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugWidget.NativeFieldInfoPtr_LastTimeUsed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugWidget.NativeFieldInfoPtr_LastTimeUsed)) = value;
      }
    }
  }
}
