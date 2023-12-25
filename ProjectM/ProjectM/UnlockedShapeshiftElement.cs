// Decompiled with JetBrains decompiler
// Type: ProjectM.UnlockedShapeshiftElement
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UnlockedShapeshiftElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlockedShapeshift;
    private static readonly System.IntPtr NativeFieldInfoPtr_UserHasRequiredContentFlags;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_PrefabGUID_UnlockedShapeshiftElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UnlockedShapeshiftElement_PrefabGUID_0;
    [FieldOffset(0)]
    public PrefabGUID UnlockedShapeshift;
    [FieldOffset(4)]
    public bool UserHasRequiredContentFlags;

    [CallerCount(504)]
    [CachedScanResults(RefRangeStart = 279526, RefRangeEnd = 280030, XrefRangeStart = 279526, XrefRangeEnd = 280030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator PrefabGUID(UnlockedShapeshiftElement e)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &e;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnlockedShapeshiftElement.NativeMethodInfoPtr_op_Implicit_Public_Static_PrefabGUID_UnlockedShapeshiftElement_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 1028978, RefRangeEnd = 1028988, XrefRangeStart = 1028978, XrefRangeEnd = 1028978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator UnlockedShapeshiftElement(PrefabGUID e)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &e;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnlockedShapeshiftElement.NativeMethodInfoPtr_op_Implicit_Public_Static_UnlockedShapeshiftElement_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(UnlockedShapeshiftElement*) IL2CPP.il2cpp_object_unbox(num);
    }

    static UnlockedShapeshiftElement()
    {
      Il2CppClassPointerStore<UnlockedShapeshiftElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (UnlockedShapeshiftElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnlockedShapeshiftElement>.NativeClassPtr);
      UnlockedShapeshiftElement.NativeFieldInfoPtr_UnlockedShapeshift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnlockedShapeshiftElement>.NativeClassPtr, nameof (UnlockedShapeshift));
      UnlockedShapeshiftElement.NativeFieldInfoPtr_UserHasRequiredContentFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnlockedShapeshiftElement>.NativeClassPtr, nameof (UserHasRequiredContentFlags));
      UnlockedShapeshiftElement.NativeMethodInfoPtr_op_Implicit_Public_Static_PrefabGUID_UnlockedShapeshiftElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnlockedShapeshiftElement>.NativeClassPtr, 100680335);
      UnlockedShapeshiftElement.NativeMethodInfoPtr_op_Implicit_Public_Static_UnlockedShapeshiftElement_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnlockedShapeshiftElement>.NativeClassPtr, 100680336);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnlockedShapeshiftElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
