// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.SupportedDotsPropertyUtility
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
namespace ProjectM.Sequencer
{
  public static class SupportedDotsPropertyUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMaterialPropertyType_Public_Static_MaterialPropertyTypeEnum_SupportedDotsProperty_0;

    [CallerCount(0)]
    public static unsafe MaterialPropertyTypeEnum GetMaterialPropertyType(
      SupportedDotsProperty property)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &property;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SupportedDotsPropertyUtility.NativeMethodInfoPtr_GetMaterialPropertyType_Public_Static_MaterialPropertyTypeEnum_SupportedDotsProperty_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(MaterialPropertyTypeEnum*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SupportedDotsPropertyUtility()
    {
      Il2CppClassPointerStore<SupportedDotsPropertyUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (SupportedDotsPropertyUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SupportedDotsPropertyUtility>.NativeClassPtr);
      SupportedDotsPropertyUtility.NativeMethodInfoPtr_GetMaterialPropertyType_Public_Static_MaterialPropertyTypeEnum_SupportedDotsProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedDotsPropertyUtility>.NativeClassPtr, 100686459);
    }

    public SupportedDotsPropertyUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
