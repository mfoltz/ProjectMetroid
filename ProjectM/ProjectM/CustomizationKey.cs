// Decompiled with JetBrains decompiler
// Type: ProjectM.CustomizationKey
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
  public struct CustomizationKey
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Category;
    private static readonly System.IntPtr NativeFieldInfoPtr_Index;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CustomizationCategoryEnum_Int32_0;
    [FieldOffset(0)]
    public CustomizationCategoryEnum Category;
    [FieldOffset(4)]
    public int Index;

    [CallerCount(12)]
    [CachedScanResults(RefRangeStart = 633602, RefRangeEnd = 633614, XrefRangeStart = 633602, XrefRangeEnd = 633614, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CustomizationKey(CustomizationCategoryEnum category, int index)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &category;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomizationKey.NativeMethodInfoPtr__ctor_Public_Void_CustomizationCategoryEnum_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CustomizationKey()
    {
      Il2CppClassPointerStore<CustomizationKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CustomizationKey));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomizationKey>.NativeClassPtr);
      CustomizationKey.NativeFieldInfoPtr_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationKey>.NativeClassPtr, nameof (Category));
      CustomizationKey.NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationKey>.NativeClassPtr, nameof (Index));
      CustomizationKey.NativeMethodInfoPtr__ctor_Public_Void_CustomizationCategoryEnum_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationKey>.NativeClassPtr, 100681875);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CustomizationKey>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
