// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.Editor.EditorECSTicker
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Terrain.Editor
{
  public class EditorECSTicker : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__EnableConstantTicking;
    private static readonly System.IntPtr NativeFieldInfoPtr_DirtyTarget;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Enable_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Disable_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetEnabled_Private_Void_Boolean_0;

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 110551, RefRangeEnd = 110559, XrefRangeStart = 110551, XrefRangeEnd = 110559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EditorECSTicker(UnityEngine.Object dirtyTarget)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EditorECSTicker>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) dirtyTarget);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EditorECSTicker.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Enable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EditorECSTicker.NativeMethodInfoPtr_Enable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Disable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EditorECSTicker.NativeMethodInfoPtr_Disable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetEnabled(bool enabled)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &enabled;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EditorECSTicker.NativeMethodInfoPtr_SetEnabled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static EditorECSTicker()
    {
      Il2CppClassPointerStore<EditorECSTicker>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain.Editor", nameof (EditorECSTicker));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EditorECSTicker>.NativeClassPtr);
      EditorECSTicker.NativeFieldInfoPtr__EnableConstantTicking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorECSTicker>.NativeClassPtr, nameof (_EnableConstantTicking));
      EditorECSTicker.NativeFieldInfoPtr_DirtyTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorECSTicker>.NativeClassPtr, nameof (DirtyTarget));
      EditorECSTicker.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorECSTicker>.NativeClassPtr, 100668016);
      EditorECSTicker.NativeMethodInfoPtr_Enable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorECSTicker>.NativeClassPtr, 100668017);
      EditorECSTicker.NativeMethodInfoPtr_Disable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorECSTicker>.NativeClassPtr, 100668018);
      EditorECSTicker.NativeMethodInfoPtr_SetEnabled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorECSTicker>.NativeClassPtr, 100668019);
    }

    public EditorECSTicker(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool _EnableConstantTicking
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorECSTicker.NativeFieldInfoPtr__EnableConstantTicking));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorECSTicker.NativeFieldInfoPtr__EnableConstantTicking)) = value;
      }
    }

    public unsafe UnityEngine.Object DirtyTarget
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorECSTicker.NativeFieldInfoPtr_DirtyTarget));
        return pointer == System.IntPtr.Zero ? (UnityEngine.Object) null : new UnityEngine.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EditorECSTicker.NativeFieldInfoPtr_DirtyTarget), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
