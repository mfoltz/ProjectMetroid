// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.ConnectAddressJsonConverter
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Newtonsoft.Json;
using Stunlock.Network;

#nullable disable
namespace ProjectM.Shared
{
  public class ConnectAddressJsonConverter : JsonConverter<ConnectAddress>
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadJson_Public_Virtual_ConnectAddress_JsonReader_Type_ConnectAddress_Boolean_JsonSerializer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteJson_Public_Virtual_Void_JsonWriter_ConnectAddress_JsonSerializer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118948, XrefRangeEnd = 1118952, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe ConnectAddress ReadJson(
      JsonReader reader,
      Il2CppSystem.Type objectType,
      ConnectAddress existingValue,
      bool hasExistingValue,
      JsonSerializer serializer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) reader);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) objectType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &existingValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &hasExistingValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) serializer);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ConnectAddressJsonConverter.NativeMethodInfoPtr_ReadJson_Public_Virtual_ConnectAddress_JsonReader_Type_ConnectAddress_Boolean_JsonSerializer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ConnectAddress*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118952, XrefRangeEnd = 1118953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void WriteJson(
      JsonWriter writer,
      ConnectAddress value,
      JsonSerializer serializer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) writer);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) serializer);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ConnectAddressJsonConverter.NativeMethodInfoPtr_WriteJson_Public_Virtual_Void_JsonWriter_ConnectAddress_JsonSerializer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118953, XrefRangeEnd = 1118956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ConnectAddressJsonConverter()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConnectAddressJsonConverter>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConnectAddressJsonConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ConnectAddressJsonConverter()
    {
      Il2CppClassPointerStore<ConnectAddressJsonConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Shared", nameof (ConnectAddressJsonConverter));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConnectAddressJsonConverter>.NativeClassPtr);
      ConnectAddressJsonConverter.NativeMethodInfoPtr_ReadJson_Public_Virtual_ConnectAddress_JsonReader_Type_ConnectAddress_Boolean_JsonSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectAddressJsonConverter>.NativeClassPtr, 100688759);
      ConnectAddressJsonConverter.NativeMethodInfoPtr_WriteJson_Public_Virtual_Void_JsonWriter_ConnectAddress_JsonSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectAddressJsonConverter>.NativeClassPtr, 100688760);
      ConnectAddressJsonConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectAddressJsonConverter>.NativeClassPtr, 100688761);
    }

    public ConnectAddressJsonConverter(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
