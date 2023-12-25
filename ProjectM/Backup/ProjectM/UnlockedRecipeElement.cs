// Decompiled with JetBrains decompiler
// Type: ProjectM.UnlockedRecipeElement
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
  public struct UnlockedRecipeElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlockedRecipe;
    private static readonly System.IntPtr NativeFieldInfoPtr_UserHasRequiredContentFlags;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_PrefabGUID_UnlockedRecipeElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UnlockedRecipeElement_PrefabGUID_0;
    [FieldOffset(0)]
    public PrefabGUID UnlockedRecipe;
    [FieldOffset(4)]
    public bool UserHasRequiredContentFlags;

    [CallerCount(504)]
    [CachedScanResults(RefRangeStart = 279526, RefRangeEnd = 280030, XrefRangeStart = 279526, XrefRangeEnd = 280030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator PrefabGUID(UnlockedRecipeElement e)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &e;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnlockedRecipeElement.NativeMethodInfoPtr_op_Implicit_Public_Static_PrefabGUID_UnlockedRecipeElement_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 1028978, RefRangeEnd = 1028988, XrefRangeStart = 1028978, XrefRangeEnd = 1028988, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator UnlockedRecipeElement(PrefabGUID e)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &e;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnlockedRecipeElement.NativeMethodInfoPtr_op_Implicit_Public_Static_UnlockedRecipeElement_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(UnlockedRecipeElement*) IL2CPP.il2cpp_object_unbox(num);
    }

    static UnlockedRecipeElement()
    {
      Il2CppClassPointerStore<UnlockedRecipeElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (UnlockedRecipeElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnlockedRecipeElement>.NativeClassPtr);
      UnlockedRecipeElement.NativeFieldInfoPtr_UnlockedRecipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnlockedRecipeElement>.NativeClassPtr, nameof (UnlockedRecipe));
      UnlockedRecipeElement.NativeFieldInfoPtr_UserHasRequiredContentFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnlockedRecipeElement>.NativeClassPtr, nameof (UserHasRequiredContentFlags));
      UnlockedRecipeElement.NativeMethodInfoPtr_op_Implicit_Public_Static_PrefabGUID_UnlockedRecipeElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnlockedRecipeElement>.NativeClassPtr, 100680337);
      UnlockedRecipeElement.NativeMethodInfoPtr_op_Implicit_Public_Static_UnlockedRecipeElement_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnlockedRecipeElement>.NativeClassPtr, 100680338);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnlockedRecipeElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
